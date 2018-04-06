using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Drawing;
using System.IO;
using UltimateBatchFileMaker.Models;
using System.Threading;

namespace UltimateBatchFileMaker
{
    public partial class MainForm : Form
    {
        OpenFileDialog fd = new OpenFileDialog();
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        private List<string[]> exportList = new List<string[]>();
        private JsonParser jsonParser;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fd.Filter = "Definition file | *definitions*.json";
            fd.Title = "Please select Definitions file";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                jsonParser = new JsonParser(fd.FileName);
                Text = Text + " - " + jsonParser.GetGameName();
            }
            else
            {
                MessageBox.Show("No definitions file selected, exiting.");
                Close();
            }

        }

        private void LoadResourceFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fd.Filter = "JSON file | *.json";
            fd.Title = "Please select Resource JSON file";
            fd.Multiselect = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                foreach (var path in fd.FileNames)
                {
                    KeyValuePair<string, DataTable> kv;
                    try
                    {
                        if (!path.ToLower().Contains("definition"))
                        {
                            kv = jsonParser.LoadResourceFile(path);
                        }
                        else
                        {
                            MessageBox.Show("Cannot load definition files as resources,skipping");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    CreateTab(kv.Key, kv.Value);
                }
            }
            else
            {
                MessageBox.Show("Resource file not found");
            }
        }

        private void LoadResourceFolderToolStripMenuItem_click(object sender, EventArgs e)
        {
            List<string> importedFiles;
            fbd.Description = "Select Resources folder";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                using (ResourceDetectionPopup rdp = new ResourceDetectionPopup())
                {
                    foreach (var file in Directory.GetFiles(fbd.SelectedPath).Where(x => x.EndsWith(".json") && !x.ToLower().Contains("definition")))
                    {
                        rdp.detectedFiles.Add(file);
                    }

                    if (rdp.ShowDialog() == DialogResult.OK)
                    {
                        importedFiles = rdp.detectedFiles;
                    }
                    else
                    {
                        MessageBox.Show("No Resource files to import");
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

            foreach (string path in importedFiles)
            {
                KeyValuePair<string,DataTable> kv = jsonParser.LoadResourceFile(path);
                CreateTab(kv.Key, kv.Value);
            }
        }

        private void Dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Left empty, because it prevents users from putting string in the 'Amount' column :)
        }

        private void Map_full_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (Map_full_rbtn.Checked == true)
            {
                UpdateMapMode("1");
            }
        }

        private void Map_markers_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (Map_markers_rbtn.Checked == true)
            {
                UpdateMapMode("1,0,1");
            }
        }

        private void Map_none_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (Map_none_rbtn.Checked == true)
            {
                UpdateMapMode("0");
            }
        }

        private void Perk_add_btn_Click(object sender, EventArgs e)
        {
            if (!Perk_txtbx.Text.Equals(""))
            {
                Perks_lstbx.Items.Add(Perk_txtbx.Text);
                Perk_txtbx.Text = "";
            }
        }

        private void Perk_remove_btn_Click(object sender, EventArgs e)
        {
            Perk_txtbx.Text = Perks_lstbx.SelectedItem.ToString();
            Perks_lstbx.Items.Remove(Perks_lstbx.SelectedItem);
        }

        private void Var_add_btn_Click(object sender, EventArgs e)
        {
            if (!Var_txtbx.Text.Equals(""))
            {
                Variables_lstbx.Items.Add(Var_txtbx.Text);
                Var_txtbx.Text = "";
            }
        }

        private void Var_remove_btn_Click(object sender, EventArgs e)
        {
            Var_txtbx.Text = Variables_lstbx.SelectedItem.ToString();
            Variables_lstbx.Items.Remove(Variables_lstbx.SelectedItem);
        }

        private void ClearAllToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void CreateDefinitionFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(CreateDefPopup cdf = new CreateDefPopup())
            {
                var ans = cdf.ShowDialog();
            }
        }

        private void CreateResourceFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CreateResFormBasic crf = new CreateResFormBasic())
            {
                var ans = crf.ShowDialog();
            }
        }

        private void CreateResourceFileAdvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CreateResFormAdv crf = new CreateResFormAdv())
            {
                var ans = crf.ShowDialog();
            }
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsOpen("HelpForm"))
            {
                new Thread(() => new HelpForm().ShowDialog()).Start();
            }
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "Ultime Batch File Maker by TheSilverHawk (a.k.a MuffinDragon)" + Environment.NewLine
                        + "Version v1.1" + Environment.NewLine
                        + "This Program is made for free use on Nexus Mods";
            MessageBox.Show(text);
        }

        private void ExtractInfo_Click(object sender, EventArgs e)
        {
            // Take care of DataGridView Items
            foreach (TabPage item in tabControl1.TabPages)
            {

                DataGridView dgv = item.Controls.OfType<DataGridView>().Single();
                Dictionary<string, string> associations = jsonParser.GetAssociations();

                foreach (DataGridViewRow row in dgv.Rows.Cast<DataGridViewRow>().Where(r => int.Parse(r.Cells["Amount"].Value.ToString()) > 0))
                {
                    string command = associations[item.Text];
                    exportList.Add(new string[] { command, row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString() });
                }
            }

            // Take care of Player GroupBox
            if (!Level_txtbx.Text.Equals(""))
            {
                exportList.Add(new string[] { jsonParser.GetCommand("Level"), Level_txtbx.Text, "" });
            }
            if (!Money_txtbx.Text.Equals(""))
            {
                exportList.Add(new string[] { jsonParser.GetCommand("Item"), "f", Money_txtbx.Text });
            }

            // Take care of Perk GroupBox
            if (Perks_lstbx.Items.Count > 0)
            {
                foreach (var perk in Perks_lstbx.Items)
                {
                    exportList.Add(new string[] { jsonParser.GetCommand("Perk"), perk.ToString(), "" });
                }
            }

            // Take care of Variable GroupBox
            if (Variables_lstbx.Items.Count > 0)
            {
                foreach (var value in Variables_lstbx.Items)
                {
                    exportList.Add(new string[] { jsonParser.GetCommand("Value"), value.ToString(), "" });
                }
            }


            // Start writing to a file
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.DefaultExt = "txt";
                sfd.AddExtension = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        foreach (var item in exportList)
                        {
                            sw.WriteLine(item[0] + " " + item[1] + " " + item[2]);
                        }
                        sw.Close();
                    }
                    exportList.Clear();
                    MessageBox.Show("Extraction complete!");
                }
                else
                {
                    MessageBox.Show("Operation canceled");
                }
            }
        }

        //
        // SUPPORT METHODS
        //
        private void CreateTab(string category, DataTable dt)
        {
            foreach (TabPage item in tabControl1.TabPages)
            {
                if (item.Text == category)
                {
                    MessageBox.Show(category + " Already exists, skipping.");
                    return;
                }
            }

            if (!jsonParser.AssociateCategory(category))
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

        private void UpdateMapMode(string mode)
        {
            string mapCommand = jsonParser.GetCommand("map");
            exportList.RemoveAll(x => x[0].Contains(mapCommand));

            exportList.Add(new string[] { mapCommand + " " + mode,"","" });
        }

        private bool IsOpen(string form_name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (var form in fc)
            {
                if (form.ToString().IndexOf(form_name) != -1)
                    return true;
            }
            return false;
        }
    }
}
