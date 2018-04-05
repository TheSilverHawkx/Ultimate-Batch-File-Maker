using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using UltimateBatchFileMaker.Models;

namespace UltimateBatchFileMaker
{
    public partial class CreateDefPopup : Form
    {
        public CreateDefPopup()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("Key");
            dt.Columns.Add("Value");

            foreach (var item in Models.DefinitionsObject.functionalityList)
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

            DataTable definitions = (DataTable)(def_dgv.DataSource);

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Definition file | *definitions*.json";
                sfd.DefaultExt = "json";
                sfd.AddExtension = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    JsonParser jsonParser = new JsonParser();

                    jsonParser.CreateDefinitionFile(Game_txtbx.Text,definitions, sfd.FileName);
                    
                    MessageBox.Show("Definition file created!");
                    Close();
                }
                else
                {
                    MessageBox.Show("No save location, aborting");
                }
            }
        }
    }
}
