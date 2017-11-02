using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FalloutBatchMaker
{
    public partial class CreateResFormAdv : Form
    {
        public CreateResFormAdv()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start ("http://www.objgen.com/json");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Output";
            int index = 0;
            string title;
            foreach (string line in Input_txtbx.Text.Split('\n'))
            {
                if (line.Contains(" = "))
                {
                    string name = Regex.Split(line, "\\s=\\s")[0];
                    string code = Regex.Split(line, "\\s=\\s")[1];
                    //string output = title
                    //"  $title[$i]`n    name = " + $name + "`n    code = " + $code
                }
                else
                {
                    title = line;
                    index = 0;
                }
            }

        }
    }
}
