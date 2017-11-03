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

namespace UltimateBatchFileMaker
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
            if (button1.Text == "Process input")
            {
                if (Category_txtbx.Text == "")
                {
                    MessageBox.Show("Category name is missing.");
                    return;
                }

                string category = Category_txtbx.Text;
                int cindex = 0;
                groupBox1.Text = "Output";
                int index = 0;
                string title = "";
                string output = "";
                string[] input = Input_rtxtbx.Text.Split('\n');
                Input_rtxtbx.Text = "";

                Input_rtxtbx.Text = "Game = game_name" + Environment.NewLine;
                foreach (string line in input)
                {
                    if (line.Contains(" = "))
                    {
                        string name = Regex.Split(line, "\\s=\\s")[0];
                        string code = Regex.Split(line, "\\s=\\s")[1];

                        output = "  " + title + "[" + index + "]" + Environment.NewLine + "    name = " + name + Environment.NewLine + "    code = " + code + Environment.NewLine;
                        Input_rtxtbx.Text += output;
                        index++;
                    }
                    else if (!line.Contains(" = ") && line != "")
                    {
                        title = line;
                        Input_rtxtbx.Text += category + "[" + cindex + "]" + Environment.NewLine;
                        index = 0;
                        cindex++;
                    }

                }
            }
        }
    }
}
