using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FalloutBatchMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetRes_btn_Click(object sender, EventArgs e) // Set Value Resources
        {
            /*Set Button for Resources, takes all the textbox values that are int and add them into the Item list values objects.
              If the textbox value isn't a number pop a message box*/
            try
            {
                Item_List_Values.Acid = int.Parse(acd_txtbx.Text);
                Item_List_Values.Adhesive = int.Parse(adh_txtbx.Text);
                Item_List_Values.Aluminum = int.Parse(alm_txtbx.Text);
                Item_List_Values.Antiseptic = int.Parse(ant_txtbx.Text);
                Item_List_Values.Asbestos = int.Parse(asb_txtbx.Text);
                Item_List_Values.Ballistic_Fiber = int.Parse(baf_txtbx.Text);
                Item_List_Values.Bone = int.Parse(bon_txtbx.Text);
                Item_List_Values.Fiber_Optics = int.Parse(fio_txtbx.Text);
                Item_List_Values.Ceramic = int.Parse(cer_txtbx.Text);
                Item_List_Values.Circuitry = int.Parse(crc_txtbx.Text);
                Item_List_Values.Cloth = int.Parse(clo_txtbx.Text);
                Item_List_Values.Concrete = int.Parse(con_txtbx.Text);
                Item_List_Values.Copper = int.Parse(cop_txtbx.Text);
                Item_List_Values.Cork = int.Parse(cor_txtbx.Text);
                Item_List_Values.Crystal = int.Parse(cry_txtbx.Text);
                Item_List_Values.Fertilizer = int.Parse(fer_txtbx.Text);
                Item_List_Values.Fiberglass = int.Parse(fib_txtbx.Text);
                Item_List_Values.Gears = int.Parse(grs_txtbx.Text);
                Item_List_Values.Glass = int.Parse(gls_txtbx.Text);
                Item_List_Values.Gold = int.Parse(gld_txtbx.Text);
                Item_List_Values.Lead = int.Parse(led_txtbx.Text);
                Item_List_Values.Leather = int.Parse(ltr_txtbx.Text);
                Item_List_Values.Nuclear_Material = int.Parse(num_txtbx.Text);
                Item_List_Values.Oil = int.Parse(oil_txtbx.Text);
                Item_List_Values.Plastic = int.Parse(pls_txtbx.Text);
                Item_List_Values.Rubber = int.Parse(rbr_txtbx.Text);
                Item_List_Values.Screw = int.Parse(scr_txtbx.Text);
                Item_List_Values.Silver = int.Parse(slv_txtbx.Text);
                Item_List_Values.Spring = int.Parse(spr_txtbx.Text);
                Item_List_Values.Steel = int.Parse(stl_txtbx.Text);
                Item_List_Values.Wood = int.Parse(wod_txtbx.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("One or more values are not numbers..");
            }
            
        }

        private void button2_Click(object sender, EventArgs e) // Clear Values Resources
        {
            // Set textboxes to 0 and clears the Item List values for Resources.
            Item_List_Values.Acid = 0;
            Item_List_Values.Adhesive = 0;
            Item_List_Values.Aluminum = 0;
            Item_List_Values.Antiseptic = 0;
            Item_List_Values.Asbestos = 0;
            Item_List_Values.Ballistic_Fiber = 0;
            Item_List_Values.Bone = 0;
            Item_List_Values.Fiber_Optics = 0;
            Item_List_Values.Ceramic = 0;
            Item_List_Values.Circuitry = 0;
            Item_List_Values.Cloth = 0;
            Item_List_Values.Concrete = 0;
            Item_List_Values.Copper = 0;
            Item_List_Values.Cork = 0;
            Item_List_Values.Crystal = 0;
            Item_List_Values.Fertilizer = 0; 
            Item_List_Values.Fiberglass = 0;
            Item_List_Values.Gears = 0;
            Item_List_Values.Glass = 0;
            Item_List_Values.Gold = 0;
            Item_List_Values.Lead = 0;
            Item_List_Values.Leather = 0;
            Item_List_Values.Nuclear_Material = 0;
            Item_List_Values.Oil = 0;
            Item_List_Values.Plastic = 0;
            Item_List_Values.Rubber = 0;
            Item_List_Values.Screw = 0;
            Item_List_Values.Silver = 0;
            Item_List_Values.Spring = 0;
            Item_List_Values.Steel = 0;
            Item_List_Values.Wood = 0;

            acd_txtbx.Text = "0";
            adh_txtbx.Text = "0";
            alm_txtbx.Text = "0";
            ant_txtbx.Text = "0";
            asb_txtbx.Text = "0";
            baf_txtbx.Text = "0";
            bon_txtbx.Text = "0";
            cer_txtbx.Text = "0";
            crc_txtbx.Text = "0";
            clo_txtbx.Text = "0";
            con_txtbx.Text = "0";
            cop_txtbx.Text = "0";
            cor_txtbx.Text = "0";
            cry_txtbx.Text = "0";
            fer_txtbx.Text = "0";
            fio_txtbx.Text = "0";
            fib_txtbx.Text = "0";
            grs_txtbx.Text = "0";
            gls_txtbx.Text = "0";
            gld_txtbx.Text = "0";
            led_txtbx.Text = "0";
            ltr_txtbx.Text = "0";
            num_txtbx.Text = "0";
            oil_txtbx.Text = "0";
            pls_txtbx.Text = "0";
            rbr_txtbx.Text = "0";
            scr_txtbx.Text = "0";
            slv_txtbx.Text = "0";
            spr_txtbx.Text = "0";
            stl_txtbx.Text = "0";
            wod_txtbx.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e) // Set Value Food
        {
            /* Same as Resource set value button, but for food */
            try
            {
                Item_List_Values.Carrot = int.Parse(crt_txtbx.Text);
                Item_List_Values.Corn = int.Parse(crn_txtbx.Text);
                Item_List_Values.Gourd = int.Parse(grd_txtbx.Text);
                Item_List_Values.Melon = int.Parse(mln_txtbx.Text);
                Item_List_Values.Mutfruit = int.Parse(mtf_txtbx.Text);
                Item_List_Values.Razorgrain = int.Parse(rzr_txtbx.Text);
                Item_List_Values.Tato = int.Parse(tto_txtbx.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("One or more values are not numbers..");
            }
        }

        private void button4_Click(object sender, EventArgs e) // Food Clear
        {
            /* Same as Resource clear values, but.... food */
            Item_List_Values.Carrot = 0;
            Item_List_Values.Corn = 0;
            Item_List_Values.Gourd = 0;
            Item_List_Values.Melon = 0;
            Item_List_Values.Mutfruit = 0;
            Item_List_Values.Razorgrain = 0;
            Item_List_Values.Tato = 0;

            crt_txtbx.Text = "0";
            crn_txtbx.Text = "0";
            grd_txtbx.Text = "0";
            mln_txtbx.Text = "0";
            mtf_txtbx.Text = "0";
            rzr_txtbx.Text = "0";
            tto_txtbx.Text = "0";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) // Menu New
        {
            Item_List_Values.Carrot = 0;
            Item_List_Values.Corn = 0;
            Item_List_Values.Gourd = 0;
            Item_List_Values.Melon = 0;
            Item_List_Values.Mutfruit = 0;
            Item_List_Values.Razorgrain = 0;
            Item_List_Values.Tato = 0;
            Item_List_Values.Acid = 0;
            Item_List_Values.Adhesive = 0;
            Item_List_Values.Aluminum = 0;
            Item_List_Values.Antiseptic = 0;
            Item_List_Values.Asbestos = 0;
            Item_List_Values.Ballistic_Fiber = 0;
            Item_List_Values.Bone = 0;
            Item_List_Values.Fiber_Optics = 0;
            Item_List_Values.Ceramic = 0;
            Item_List_Values.Circuitry = 0;
            Item_List_Values.Cloth = 0;
            Item_List_Values.Concrete = 0;
            Item_List_Values.Copper = 0;
            Item_List_Values.Cork = 0;
            Item_List_Values.Crystal = 0;
            Item_List_Values.Fertilizer = 0;
            Item_List_Values.Fiberglass = 0;
            Item_List_Values.Gears = 0;
            Item_List_Values.Glass = 0;
            Item_List_Values.Gold = 0;
            Item_List_Values.Lead = 0;
            Item_List_Values.Leather = 0;
            Item_List_Values.Nuclear_Material = 0;
            Item_List_Values.Oil = 0;
            Item_List_Values.Plastic = 0;
            Item_List_Values.Rubber = 0;
            Item_List_Values.Screw = 0;
            Item_List_Values.Silver = 0;
            Item_List_Values.Spring = 0;
            Item_List_Values.Steel = 0;
            Item_List_Values.Wood = 0;

            acd_txtbx.Text = "0";
            adh_txtbx.Text = "0";
            alm_txtbx.Text = "0";
            ant_txtbx.Text = "0";
            asb_txtbx.Text = "0";
            baf_txtbx.Text = "0";
            bon_txtbx.Text = "0";
            cer_txtbx.Text = "0";
            crc_txtbx.Text = "0";
            clo_txtbx.Text = "0";
            con_txtbx.Text = "0";
            cop_txtbx.Text = "0";
            cor_txtbx.Text = "0";
            cry_txtbx.Text = "0";
            fer_txtbx.Text = "0";
            fio_txtbx.Text = "0";
            fib_txtbx.Text = "0";
            grs_txtbx.Text = "0";
            gls_txtbx.Text = "0";
            gld_txtbx.Text = "0";
            led_txtbx.Text = "0";
            ltr_txtbx.Text = "0";
            num_txtbx.Text = "0";
            oil_txtbx.Text = "0";
            pls_txtbx.Text = "0";
            rbr_txtbx.Text = "0";
            scr_txtbx.Text = "0";
            slv_txtbx.Text = "0";
            spr_txtbx.Text = "0";
            stl_txtbx.Text = "0";
            wod_txtbx.Text = "0";
            crt_txtbx.Text = "0";
            crn_txtbx.Text = "0";
            grd_txtbx.Text = "0";
            mln_txtbx.Text = "0";
            mtf_txtbx.Text = "0";
            rzr_txtbx.Text = "0";
            tto_txtbx.Text = "0";

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) // Menu Clear
        {
            acd_txtbx.Text = "0";
            adh_txtbx.Text = "0";
            alm_txtbx.Text = "0";
            ant_txtbx.Text = "0";
            asb_txtbx.Text = "0";
            baf_txtbx.Text = "0";
            bon_txtbx.Text = "0";
            cer_txtbx.Text = "0";
            crc_txtbx.Text = "0";
            clo_txtbx.Text = "0";
            con_txtbx.Text = "0";
            cop_txtbx.Text = "0";
            cor_txtbx.Text = "0";
            cry_txtbx.Text = "0";
            fer_txtbx.Text = "0";
            fio_txtbx.Text = "0";
            fib_txtbx.Text = "0";
            grs_txtbx.Text = "0";
            gls_txtbx.Text = "0";
            gld_txtbx.Text = "0";
            led_txtbx.Text = "0";
            ltr_txtbx.Text = "0";
            num_txtbx.Text = "0";
            oil_txtbx.Text = "0";
            pls_txtbx.Text = "0";
            rbr_txtbx.Text = "0";
            scr_txtbx.Text = "0";
            slv_txtbx.Text = "0";
            spr_txtbx.Text = "0";
            stl_txtbx.Text = "0";
            wod_txtbx.Text = "0";
            crt_txtbx.Text = "0";
            crn_txtbx.Text = "0";
            grd_txtbx.Text = "0";
            mln_txtbx.Text = "0";
            mtf_txtbx.Text = "0";
            rzr_txtbx.Text = "0";
            tto_txtbx.Text = "0";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // Menu Exit
        {
            this.Close();
        }

        public void add2Array(string item, int value) // Array add function
        {
            try
            {
                Item_List_Values.Final.Add("player.additem " + item + " " + value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                add2Array(Item_list_Code.Acid, Item_List_Values.Acid);
                add2Array(Item_list_Code.Adhesive, Item_List_Values.Adhesive);
                add2Array(Item_list_Code.Aluminum, Item_List_Values.Aluminum);
                add2Array(Item_list_Code.Antiseptic, Item_List_Values.Antiseptic);
                add2Array(Item_list_Code.Asbestos, Item_List_Values.Asbestos);
                add2Array(Item_list_Code.Ballistic_Fiber, Item_List_Values.Ballistic_Fiber);
                add2Array(Item_list_Code.Bone, Item_List_Values.Bone);
                add2Array(Item_list_Code.Fiber_Optics, Item_List_Values.Fiber_Optics);
                add2Array(Item_list_Code.Ceramic, Item_List_Values.Ceramic);
                add2Array(Item_list_Code.Circuitry, Item_List_Values.Circuitry);
                add2Array(Item_list_Code.Cloth, Item_List_Values.Cloth);
                add2Array(Item_list_Code.Concrete, Item_List_Values.Concrete);
                add2Array(Item_list_Code.Copper, Item_List_Values.Copper);
                add2Array(Item_list_Code.Cork, Item_List_Values.Cork);
                add2Array(Item_list_Code.Crystal, Item_List_Values.Crystal);
                add2Array(Item_list_Code.Fertilizer, Item_List_Values.Fertilizer);
                add2Array(Item_list_Code.Fiberglass, Item_List_Values.Fiberglass);
                add2Array(Item_list_Code.Gears, Item_List_Values.Gears);
                add2Array(Item_list_Code.Glass, Item_List_Values.Glass);
                add2Array(Item_list_Code.Gold, Item_List_Values.Gold);
                add2Array(Item_list_Code.Lead, Item_List_Values.Lead);
                add2Array(Item_list_Code.Leather, Item_List_Values.Leather);
                add2Array(Item_list_Code.Nuclear_Material, Item_List_Values.Nuclear_Material);
                add2Array(Item_list_Code.Oil, Item_List_Values.Oil);
                add2Array(Item_list_Code.Plastic, Item_List_Values.Plastic);
                add2Array(Item_list_Code.Rubber, Item_List_Values.Rubber);
                add2Array(Item_list_Code.Screw, Item_List_Values.Screw);
                add2Array(Item_list_Code.Silver, Item_List_Values.Silver);
                add2Array(Item_list_Code.Spring, Item_List_Values.Spring);
                add2Array(Item_list_Code.Steel, Item_List_Values.Steel);
                add2Array(Item_list_Code.Wood, Item_List_Values.Wood);
                add2Array(Item_list_Code.Carrot, Item_List_Values.Carrot);
                add2Array(Item_list_Code.Corn, Item_List_Values.Corn);
                add2Array(Item_list_Code.Gourd, Item_List_Values.Gourd);
                add2Array(Item_list_Code.Melon, Item_List_Values.Melon);
                add2Array(Item_list_Code.Mutfruit, Item_List_Values.Mutfruit);
                add2Array(Item_list_Code.Razorgrain, Item_List_Values.Razorgrain);
                add2Array(Item_list_Code.Tato, Item_List_Values.Tato);
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't add items to the hash");
            }
            
            SaveFileDialog saving = new SaveFileDialog();

            saving.Filter = "Text File|*.txt";
            saving.ShowDialog();
            StreamWriter saver = new StreamWriter(saving.FileName);
            foreach (var line in Item_List_Values.Final.ToArray())
	        {
                //MessageBox.Show(line.ToString());
		        saver.WriteLine(line.ToString());
	        }
            saver.Dispose();
            saver.Close();
            MessageBox.Show("File Saved.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
