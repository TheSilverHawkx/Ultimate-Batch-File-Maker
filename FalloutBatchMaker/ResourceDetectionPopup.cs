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
    public partial class ResourceDetectionPopup : Form
    {
        public List<string> detectedFiles = new List<string>();
        public List<string> importList = new List<string>();

        public ResourceDetectionPopup()
        {
            InitializeComponent();
            foreach (string file in detectedFiles)
            {
                checkedListBox1.Items.Add(file, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string item in checkedListBox1.CheckedItems.Cast<string>())
            {
                MessageBox.Show(item);
            }
        }
    }
}
