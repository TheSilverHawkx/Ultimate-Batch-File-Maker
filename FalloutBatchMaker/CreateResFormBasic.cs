using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;

namespace UltimateBatchFileMaker
{
    public partial class CreateResFormBasic : Form
    {
        public CreateResFormBasic()
        {
            InitializeComponent();
            
        }
        private void Resource_add_btn_Click(object sender, EventArgs e)
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

        private void Resource_remove_btn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Resource_lstv.SelectedItems)
            {
                Resource_lstv.Items.Remove(item);
            }
        }

        private void Create_btn_Click(object sender, EventArgs e)
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
                    exportList.Add(new string[] { item.SubItems[0].Text, item.SubItems[1].Text });
                }

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Resource File | *.json";
                    sfd.DefaultExt = "json";
                    sfd.AddExtension = true;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        JsonParser jsonParser = new JsonParser();

                        jsonParser.CreateResourceFile(Game_txtbx.Text, Category_txtbx.Text, exportList, sfd.FileName);

                        MessageBox.Show("Resource file created!");
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
}
