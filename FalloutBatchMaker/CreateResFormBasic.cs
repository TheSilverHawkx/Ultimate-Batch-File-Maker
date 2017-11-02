using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;

namespace FalloutBatchMaker
{
    public partial class CreateResFormBasic : Form
    {
        public CreateResFormBasic()
        {
            InitializeComponent();
            
        }
        private void AddRes_btn_Click(object sender, EventArgs e)
        {
            if (Name_txtbx.Text != "" && Code_txtbx.Text != "")
            {
                ListViewItem lvi = new ListViewItem(new string[] { Name_txtbx.Text, Code_txtbx.Text });
                Resource_lstv.Items.Add(lvi);
                Name_txtbx.Text = "";
                Code_txtbx.Text = "";
            }
            else
            {
                MessageBox.Show("Item name or code are missing");
            }
            
        }

        private void RemRes_btn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Resource_lstv.SelectedItems)
            {
                Resource_lstv.Items.Remove(item);
            }
        }

        private void CreateRes_btn_Click(object sender, EventArgs e)
        {
            if (Category_txtbx.Text == "" && Game_txtbx.Text == "")
            {
                MessageBox.Show("Category name or Game name are missing.");
                return;
            }
            else
            {
                List<string[]> exportList = new List<string[]>();
                foreach (ListViewItem item in Resource_lstv.Items)
                {
                    exportList.Add(new string[] { item.SubItems[0].ToString(), item.SubItems[1].ToString() });
                }

                string category_name = Category_txtbx.Text;
                JObject json = new JObject(
                    new JProperty("Game", Game_txtbx.Text),
                    new JProperty(category_name,
                        new JArray(from p in exportList select new JObject(
                            new JProperty("name",Name_txtbx.Text),
                            new JProperty("code",Code_txtbx.Text)
                            )
                        )
                    )
                );

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Resource File | *.json";
                    sfd.DefaultExt = "json";
                    sfd.AddExtension = true;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter sw = new StreamWriter(sfd.FileName);

                        sw.Write(json.ToString());
                        sw.Close();
                        MessageBox.Show("Resource file created!");
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
}
