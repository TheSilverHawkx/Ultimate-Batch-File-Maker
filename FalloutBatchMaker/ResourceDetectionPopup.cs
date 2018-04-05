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

        public ResourceDetectionPopup()
        {
            InitializeComponent();
            
        }

        private void ResourceDetectionPopup_Load(object sender, EventArgs e)
        {
            foreach (string file in detectedFiles)
            {
                checkedListBox1.Items.Add(file.Split('\\').Last(), true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    detectedFiles.RemoveAll(x => x.ToString().Contains(checkedListBox1.Items[i].ToString()));
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
