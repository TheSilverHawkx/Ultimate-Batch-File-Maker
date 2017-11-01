using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FalloutBatchMaker
{
    public partial class AssociationPopup : Form
    {
        public string ReturnValue { get; set; }

        public AssociationPopup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cmd_txtbx.Text != "")
            {
                this.ReturnValue = cmd_txtbx.Text;
                this.DialogResult = DialogResult.OK;
            }
            else if (categories_cmbx.SelectedItem.ToString() != "")
            {
                this.ReturnValue = categories_cmbx.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }
            this.Close();
            
        }
    }
}
