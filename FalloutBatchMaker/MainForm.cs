using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;


namespace FalloutBatchMaker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            fd.Filter = "Definition file | *definitions*.json";
            fd.Title = "Please select Definitions file";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string raw_json = System.IO.File.ReadAllText(fd.FileName);

                JObject parsed_json = JObject.Parse(raw_json);

                game_name = parsed_json["Game"].Value<string>();
                try
                {
                    if (parsed_json["Definitions"].HasValues)
                    {

                        commands = new Definitions(
                            parsed_json["Definitions"]["addItem"].ToString(),
                            parsed_json["Definitions"]["setValue"].ToString(),
                            parsed_json["Definitions"]["addPerk"].ToString(),
                            parsed_json["Definitions"]["spawnNPC"].ToString(),
                            parsed_json["Definitions"]["setLevel"].ToString(),
                            parsed_json["Definitions"]["mapCommand"].ToString()
                            );
                    }
                }
                catch
                {
                    MessageBox.Show("Not a Definitions File");
                    Close();
                }
            }
        }

        OpenFileDialog fd = new OpenFileDialog();
        private Definitions commands;
        private string game_name;
        private List<JObject> master_values = new List<JObject>();

        private DataTable populateTable(List<JObject> values)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Category");
            dt.Columns.Add("Name");
            dt.Columns.Add("Code");
            dt.Columns.Add("Amount",Type.GetType("System.Int32"));


            foreach (JObject row in values)
            {
                DataRow dr = dt.NewRow();
                dr["Category"] = row.Property("itemCategory").Value; ;
                dr["Name"] = row.Property("name").Value;
                dr["Code"] = row.Property("code").Value;
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void createTab(string category, DataTable dt)
        {

            TabPage tp = new TabPage(category);            
            tabControl1.Controls.Add(tp);

            DataGridView dgv = new DataGridView();
            dgv.DataSource = "";
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
            ToolStripButton tssbtn = new ToolStripButton("Search");

            ToolStripButton tscbtn = new ToolStripButton("Clear");
            tscbtn.Name = category + " clear_btn";
            tscbtn.Alignment = ToolStripItemAlignment.Right;

            tssbtn.Name = category + " search_btn";
            tssbtn.Alignment = ToolStripItemAlignment.Right;

            tssbtn.Click += (o, s) =>
            {
                (dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name like '%{0}%'", tstxtbx.Text);
            };

            tscbtn.Click += (o, s) =>
            {
                (dgv.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            };

            dgv.DataError += Dgv_DataError;
            dgv.CellValueChanged += (o, s) =>
            {
                
                var count = dgv.Rows.Cast<DataGridViewRow>()
                    .Count(row => row.Cells["Amount"].Value.ToString() != "");
                tsl2c.Text = count.ToString();
            };
            bn.Items.Add(tsl1);
            bn.Items.Add(tsl1c);
            bn.Items.Add(tsp);
            bn.Items.Add(tsl2);
            bn.Items.Add(tsl2c);
            bn.Items.Add(tscbtn);
            bn.Items.Add(tssbtn);
            bn.Items.Add(tstxtbx);
            bn.Dock = DockStyle.Top;
            tp.Controls.Add(bn);
        }

        private void Dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Empty, but not letting you put string in Amount column which is good :)
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

                    if (parsed_json["Game"].Value<string>() == "Fallout 4")
                    {
                        string category_name = parsed_json.Properties().Select(p => p.Name).ToList()[1];

                        if (parsed_json[category_name].First().Count() != 2)
                        {
                            foreach (JObject child in parsed_json.Children().Last().Values())
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
                }

            }
            else
            {
                MessageBox.Show("Could not find Resource file.");
            }
        }

        private void ExtractInfo_Click(object sender, EventArgs e)
        {
            //List<> list = new List<DataGridViewRow>();
            foreach (TabPage item in tabControl1.TabPages)
            {
                DataGridView dgv = (DataGridView)item.Controls.OfType<DataGridView>().Single();

                foreach (DataGridViewRow row in dgv.Rows.Cast<DataGridViewRow>().Where(r => !r.Cells["Amount"].Value.ToString().Equals("")))
                {

                    MessageBox.Show(row.Cells[1].Value.ToString());
                }
                
                
            }
        }
    }


}
