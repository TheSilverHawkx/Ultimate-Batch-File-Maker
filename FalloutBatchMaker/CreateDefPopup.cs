using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;

namespace FalloutBatchMaker
{
    public partial class CreateDefPopup : Form
    {
        public CreateDefPopup()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("Key");
            dt.Columns.Add("Value");

            foreach (var item in Definitions.functionalityList)
            {
                DataRow dr = dt.NewRow();
                dr["Key"] = item;
                
                dt.Rows.Add(dr);
            }

            def_dgv.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check there's a game name
            if (Game_txtbx.Text == "")
            {
                MessageBox.Show("Missing game name");
                return;
            }

            // Check all definitions are filled
            foreach (DataGridViewRow item in def_dgv.Rows.Cast<DataGridViewRow>())
            {
                if (item.Cells["Value"].Value.Equals(""))
                {
                    MessageBox.Show(item.Cells[0].Value + " missing definition");
                    return;
                }
            }
            JObject json = JObject.FromObject(new
            {
                Game = Game_txtbx.Text,
                Definitions = new
                {
                    addItem = def_dgv.Rows[0].Cells[1].Value.ToString(),
                    setValue = def_dgv.Rows[1].Cells[1].Value.ToString(),
                    addPerk = def_dgv.Rows[2].Cells[1].Value.ToString(),
                    spawnNPC = def_dgv.Rows[3].Cells[1].Value.ToString(),
                    setLevel = def_dgv.Rows[4].Cells[1].Value.ToString(),
                    mapCommand = def_dgv.Rows[5].Cells[1].Value.ToString()
                }
            });
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Definition file | *definitions*.json";
                sfd.DefaultExt = "json";
                sfd.AddExtension = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);

                    sw.Write(json.ToString());
                    sw.Close();
                    MessageBox.Show("Definition file created!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No save location, aborting");
                }
            }
        }
    }
}
