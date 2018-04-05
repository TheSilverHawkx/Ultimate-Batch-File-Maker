using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimateBatchFileMaker
{
    public partial class AssociationPopup : Form
    {
        public string CategoryName { get; set; }
        public string ReturnValue { get; set; }

        public AssociationPopup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cmd_txtbx.Text != "")
            {
                ReturnValue = cmd_txtbx.Text;
                DialogResult = DialogResult.OK;
            }
            else if (categories_cmbx.SelectedItem.ToString() != "")
            {
                ReturnValue = categories_cmbx.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Abort;
            }
            Close();
            
        }

        private void AssociationPopup_Load(object sender, EventArgs e)
        {
            Text = Text + " - " + CategoryName;
        }
    }
}
