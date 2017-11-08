using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Drawing;
using System.IO;

namespace UltimateBatchFileMaker
{
    public partial class MainForm : Form
    {
        OpenFileDialog fd = new OpenFileDialog();
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        private Definitions definition;
        private List<JObject> master_values = new List<JObject>();
        private List<string[]> exportList = new List<string[]>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fd.Filter = "JSON file | *.json";
            fd.Title = "Please select Resource JSON file";
            fd.Multiselect = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filepath in fd.FileNames)
                {
                    string raw_json = System.IO.File.ReadAllText(filepath);


                    JObject parsed_json = JObject.Parse(raw_json);

                    if (parsed_json["Game"].Value<string>() == definition.GameName)
                    {
                        string category_name = parsed_json.Properties().Select(p => p.Name).ToList()[1];


                        if (parsed_json[category_name].First().Count() != 2)
                        {
                            foreach (JObject child in parsed_json[category_name].Children<JObject>())
                            {
                                string item_category = child.Properties().Select(p => p.Name).ToList()[0];

                                foreach (JObject item in child.Children().First().Values())
                                {
                                    item.Add("itemCategory", item_category);
                                    master_values.Add(item);
                                }
                            }
                            DataTable dt = populateTable(master_values);
                            createTab(category_name, dt);
                            master_values.Clear();
                        }
                        else
                        {
                            foreach (JObject child in parsed_json[category_name].Children<JObject>())
                            {
                                child.Add("itemCategory", category_name);
                                master_values.Add(child);

                            }
                            DataTable dt = populateTable(master_values);
                            createTab(category_name, dt);
                            master_values.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show(filepath + " does not belong to " + definition.GameName);
                    }
                }
            }
            else
            {
                MessageBox.Show("Could not find Resource file.");
            }
        }

        private void ExtractInfo_Click(object sender, EventArgs e)
        {
            // Take care of DataGridView Items
            foreach (TabPage item in tabControl1.TabPages)
            {
                
                DataGridView dgv = item.Controls.OfType<DataGridView>().Single();
                Dictionary<string, string> associations = definition.GetAssociations();

                foreach (DataGridViewRow row in dgv.Rows.Cast<DataGridViewRow>().Where(r => int.Parse(r.Cells["Amount"].Value.ToString()) > 0))
                {
                    string command = associations[item.Text];
                    exportList.Add(new string[] { command,row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString() });
                } 
            }

            // Take care of Player GroupBox
            if (!Level_txtbx.Text.Equals(""))
            {
                exportList.Add(new string[] { definition.SetLevel(Level_txtbx.Text), "", "" });
            }
            if (!Money_txtbx.Text.Equals(""))
            {
                exportList.Add(new string[] { definition.Additem("f", int.Parse(Money_txtbx.Text)), "", "" });
            }

            // Take care of Perk GroupBox
            if (Perks_lstbx.Items.Count > 0)
            {
                foreach (var item in Perks_lstbx.Items)
                {
                    exportList.Add(new string[] { definition.AddPerk(item.ToString()), "", "" });
                }
            }

            // Take care of Variable GroupBox
            if (Variables_lstbx.Items.Count > 0)
            {
                foreach (var item in Variables_lstbx.Items)
                {
                    exportList.Add(new string[] { definition.SetVariable(item.ToString()), "", "" });
                }
            }


            // Start writing to a file
            StreamWriter sw;
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.DefaultExt = "txt";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(sfd.FileName);
                foreach (var item in exportList)
                {
                    sw.WriteLine(item[0] + " " + item[1] + " " + item[2]);
                }
                sw.Close();
                exportList.Clear();
                MessageBox.Show("Extraction complete!");
            }
            else
            {
                MessageBox.Show("Operation canceled");
            }
        }

        private DataTable populateTable(List<JObject> values)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Category");
            dt.Columns.Add("Name");
            dt.Columns.Add("Code");
            dt.Columns.Add("Amount", Type.GetType("System.Int32"));


            foreach (JObject row in values)
            {
                DataRow dr = dt.NewRow();
                dr["Category"] = row.Property("itemCategory").Value; ;
                dr["Name"] = row.Property("name").Value;
                dr["Code"] = row.Property("code").Value;
                dr["Amount"] = 0;
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void createTab(string category, DataTable dt)
        {
            foreach (TabPage item in tabControl1.TabPages)
            {
                if (item.Text == category)
                {
                    MessageBox.Show(category + " Already exists, skipping.");
                    return;
                }
            }

            if (!associateCategory(category))
            {
                return;
            }

            TabPage tp = new TabPage(category);
            tabControl1.Controls.Add(tp);
            
            DataGridView dgv = new DataGridView();
            dgv.Dock = DockStyle.Fill;
            dgv.Name = category + "DGView";
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv.DataSource = dt;
            tp.Controls.Add(dgv);




            BindingNavigator bn = new BindingNavigator();
            ToolStripSeparator tsp = new ToolStripSeparator();
            ToolStripLabel tsl1 = new ToolStripLabel("List Count:");
            ToolStripLabel tsl1c = new ToolStripLabel();
            tsl1c.Text = dt.Rows.Count.ToString();
            tsl1c.Name = category + "total_items_lbl";
            ToolStripLabel tsl2 = new ToolStripLabel("Selected Items:");
            ToolStripLabel tsl2c = new ToolStripLabel("0");
            tsl2c.Name = category + "total_items_lbl";
            ToolStripTextBox tstxtbx = new ToolStripTextBox(category + "search_txtbx");
            tstxtbx.Alignment = ToolStripItemAlignment.Right;
            tstxtbx.ForeColor = Color.Gray;
            tstxtbx.Text = "search";

            ToolStripButton tscbtn = new ToolStripButton("Clear");
            tscbtn.Name = category + " clear_btn";
            tscbtn.Alignment = ToolStripItemAlignment.Right;


            // Create placeholder-like behavior
            tstxtbx.Leave += (o, s) =>
            {
                if (tstxtbx.Text == "")
                {
                    tstxtbx.Text = "search";
                    tstxtbx.ForeColor = Color.Gray;
                }
            };
            tstxtbx.Enter += (o, s) =>
            {
                if (tstxtbx.Text == "search")
                {
                    tstxtbx.ForeColor = Color.Black;
                    tstxtbx.Text = "";
                }
            };

            // Filter on key release
            tstxtbx.KeyUp += (o, s) =>
            {
                (dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name like '%{0}%'", tstxtbx.Text);
            };

            // Clear filter button click
            tscbtn.Click += (o, s) =>
            {
                (dgv.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                tstxtbx.ForeColor = Color.Gray;
                tstxtbx.Text = "search";
            };



            dgv.DataError += Dgv_DataError;

            // On cell value change
            dgv.CellValueChanged += (o, s) =>
            {
                List<DataGridViewRow> list = dgv.Rows.Cast<DataGridViewRow>().Where(row => row.Cells["Amount"].Value.ToString().Equals("")).ToList();
                foreach (var item in list)
                {
                    item.Cells["Amount"].Value = 0;
                }


                var count = dgv.Rows.Cast<DataGridViewRow>()
                    .Count(row => int.Parse(row.Cells["Amount"].Value.ToString()) > 0);
                tsl2c.Text = count.ToString();
            };
            bn.Items.Add(tsl1);
            bn.Items.Add(tsl1c);
            bn.Items.Add(tsp);
            bn.Items.Add(tsl2);
            bn.Items.Add(tsl2c);
            bn.Items.Add(tscbtn);
            bn.Items.Add(tstxtbx);
            bn.Dock = DockStyle.Top;
            tp.Controls.Add(bn);
        }

        private void Dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Empty, but not letting you put string in Amount column which is good :)
        }

        private bool associateCategory(string category_name)
        {
            string[] item_types = { "Weapons", "Ammo", "Armor", "Items", "Food" };

            if (item_types.Contains(category_name))
            {
                definition.AddAssociation(category_name, "Item");
            }
            else if (category_name ==  "Actors")
            {
                definition.AddAssociation(category_name, "NPC");
            }
            else
            {
                using (AssociationPopup frm = new AssociationPopup())
                {
                    frm.CategoryName = category_name;
                    var ans = frm.ShowDialog();
                    if ( ans == DialogResult.OK)
                    {
                        string val = frm.ReturnValue;
                        definition.AddAssociation(category_name, val);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No association specified, skipping");
                        return false;
                    }
                }

            }
            return true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                exportList.Add(new string[] { definition.MapCommand("1"), "", "" });
            }
            else
            {
                exportList.RemoveAll(x => x[0] == definition.MapCommand("1"));
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                exportList.Add(new string[] { definition.MapCommand("1,0,1"), "", "" });
            }
            else
            {
                exportList.RemoveAll(x => x[0] == definition.MapCommand("1,0,1"));
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                exportList.Add(new string[] { definition.MapCommand("0"), "", "" });
            }
            else
            {
                exportList.RemoveAll(x => x[0] == definition.MapCommand("0"));
            }
        }

        private void PerkAdd_btn_Click(object sender, EventArgs e)
        {
            if (!Perk_txtbx.Text.Equals(""))
            {
                Perks_lstbx.Items.Add(Perk_txtbx.Text);
                Perk_txtbx.Text = "";
            }
        }

        private void PerkRem_btn_Click(object sender, EventArgs e)
        {
            Perk_txtbx.Text = Perks_lstbx.SelectedItem.ToString();
            Perks_lstbx.Items.Remove(Perks_lstbx.SelectedItem);
        }

        private void VarAdd_btn_Click(object sender, EventArgs e)
        {
            if (!Var_txtbx.Text.Equals(""))
            {
                Variables_lstbx.Items.Add(Var_txtbx.Text);
                Var_txtbx.Text = "";
            }
        }

        private void VarRem_btn_Click(object sender, EventArgs e)
        {
            Var_txtbx.Text = Variables_lstbx.SelectedItem.ToString();
            Variables_lstbx.Items.Remove(Variables_lstbx.SelectedItem);
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                exportList.Clear();
                foreach (TabPage item in tabControl1.TabPages)
                {
                    DataGridView dgv = item.Controls.OfType<DataGridView>().Single();

                    foreach (DataGridViewRow row in dgv.Rows.Cast<DataGridViewRow>().Where(r => !r.Cells["Amount"].Value.ToString().Equals("")))
                    {
                        row.Cells[3].Value = 0;
                    }
                }
                
                foreach (var txtbx in Player_grpbx.Controls.OfType<TextBox>())
                {
                    txtbx.Text = "";
                }

                foreach (var radiobtn in Map_grpbx.Controls.OfType<RadioButton>())
                {
                    radiobtn.Checked = false;
                }

                Perks_lstbx.Items.Clear();
                Variables_lstbx.Items.Clear();
            }
            catch
            {
                MessageBox.Show("Nothing to clear");
            }
        }

        private void createDefinitionFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(CreateDefPopup cdf = new CreateDefPopup())
            {
                var ans = cdf.ShowDialog();
            }
        }

        private void createResourceFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CreateResFormBasic crf = new CreateResFormBasic())
            {
                var ans = crf.ShowDialog();
            }
        }

        private void createResourceFileAdvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CreateResFormAdv crf = new CreateResFormAdv())
            {
                var ans = crf.ShowDialog();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (HelpForm crf = new HelpForm())
            {
                var ans = crf.ShowDialog();
            }
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "Ultime Batch File Maker by TheSilverHawk (a.k.a MuffinDragon)" + Environment.NewLine
                        + "Version v1.0" + Environment.NewLine
                        + "This Program is made for free use on Nexus Mods";
            MessageBox.Show(text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fd.Filter = "Definition file | *definitions*.json";
            fd.Title = "Please select Definitions file";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string raw_json = System.IO.File.ReadAllText(fd.FileName);

                try
                {
                    JObject parsed_json = JObject.Parse(raw_json);
                    if (parsed_json["Definitions"].HasValues)
                    {

                        definition = new Definitions(
                            parsed_json["Game"].ToString(),
                            parsed_json["Definitions"]["addItem"].ToString(),
                            parsed_json["Definitions"]["setValue"].ToString(),
                            parsed_json["Definitions"]["addPerk"].ToString(),
                            parsed_json["Definitions"]["spawnNPC"].ToString(),
                            parsed_json["Definitions"]["setLevel"].ToString(),
                            parsed_json["Definitions"]["mapCommand"].ToString()
                            );
                        this.Text = this.Text + " - " + definition.GameName;
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to create definitions!" + Environment.NewLine + "Check definitions file syntax.");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("No definitions file selected, exiting.");
                this.Close();
            }
        }

        private void loadFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fbd.Description = "Select Resources folder";
            List<string> importedFiles = new List<string>();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                using (ResourceDetectionPopup rdp = new ResourceDetectionPopup())
                {
                    foreach (var file in Directory.GetFiles(fbd.SelectedPath))
                    {
                        if (!file.ToLower().Contains("definition"))
                        {
                            rdp.detectedFiles.Add(file);
                        }
                    }
                    
                    if (rdp.ShowDialog() == DialogResult.OK)
                    {
                        importedFiles = rdp.detectedFiles;
                    }
                    else
                    {
                        MessageBox.Show("No Resource files to import.");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("No Resource folder selected, exiting.");
                return;
            }

            if (importedFiles.Count == 0)
            {
                MessageBox.Show("No file to import");
                return;
            }
            foreach (string filepath in importedFiles)
            {
                string raw_json = System.IO.File.ReadAllText(filepath);


                JObject parsed_json = JObject.Parse(raw_json);

                if (parsed_json["Game"].Value<string>() == definition.GameName)
                {
                    string category_name = parsed_json.Properties().Select(p => p.Name).ToList()[1];


                    if (parsed_json[category_name].First().Count() != 2)
                    {
                        foreach (JObject child in parsed_json[category_name].Children<JObject>())
                        {
                            string item_category = child.Properties().Select(p => p.Name).ToList()[0];

                            foreach (JObject item in child.Children().First().Values())
                            {
                                item.Add("itemCategory", item_category);
                                master_values.Add(item);
                            }
                        }
                        DataTable dt = populateTable(master_values);
                        createTab(category_name, dt);
                        master_values.Clear();
                    }
                    else
                    {
                        foreach (JObject child in parsed_json[category_name].Children<JObject>())
                        {
                            child.Add("itemCategory", category_name);
                            master_values.Add(child);

                        }
                        DataTable dt = populateTable(master_values);
                        createTab(category_name, dt);
                        master_values.Clear();
                    }
                }
                else
                {
                    MessageBox.Show(filepath + " does not belong to " + definition.GameName);
                }
            }
        }
    }

    
}
