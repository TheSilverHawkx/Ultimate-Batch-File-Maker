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
using UltimateBatchFileMaker.Models;

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
                if (Category_name_txtbx.Text == "" || Game_name_txtbx.Text == "")
                {
                    MessageBox.Show("Category or Game name are missing");
                    return;
                }

                string game_name = Game_name_txtbx.Text, category_name = Category_name_txtbx.Text, subcat_name="", name, code;
                int? c_index =-1, r_index = -1;

                string[] input = Input_rtxtbx.Text.Split('\n');

                Input_rtxtbx.Text = "";
                Input_rtxtbx.Text += "Game = " + game_name + Environment.NewLine + "Name = " + category_name + Environment.NewLine;

                foreach (string row in input)
                {
                    if (!row.Contains(" = ") && row != "")
                    {
                        c_index++;
                        r_index = 0;
                        subcat_name = row;
                        Input_rtxtbx.Text += "Categories[" + c_index + "]" + Environment.NewLine + "  name = " + subcat_name + Environment.NewLine;
                    }
                    else if (row.Contains(" = "))
                    {
                        name = Regex.Split(row, "\\s=\\s")[0];
                        code = Regex.Split(row, "\\s=\\s")[1];
                        Input_rtxtbx.Text += "  Resources[" + r_index + "]" + 
                            Environment.NewLine + "    name = " + name +
                            Environment.NewLine + "    code = " + code + Environment.NewLine;
                        r_index++;
                    }
                }

                groupBox1.Text = "Output";
            }
        }

    }
}
