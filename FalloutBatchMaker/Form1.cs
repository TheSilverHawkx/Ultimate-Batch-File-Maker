using System;
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

        public void add2Array(string item, int value) // Array add function
        {
            if (value > 0)
            {
                try
                {
                    Classes.Item_List.Final.Add("player.additem " + item + " " + value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
        }

        private void SetRes_btn_Click(object sender, EventArgs e) // Set Value Resources
        {
            /*Set Button for Resources, takes all the textbox values that are int and add them into the Item list values objects.
              If the textbox value isn't a number pop a message box*/
            try
            {
                Classes.Item_List.Acid.amount = int.Parse(acd_txtbx.Text);
                Classes.Item_List.Adhesive.amount = int.Parse(adh_txtbx.Text);
                Classes.Item_List.Aluminum.amount = int.Parse(alm_txtbx.Text);
                Classes.Item_List.Antiseptic.amount = int.Parse(ant_txtbx.Text);
                Classes.Item_List.Asbestos.amount = int.Parse(asb_txtbx.Text);
                Classes.Item_List.Ballistic_Fiber.amount = int.Parse(baf_txtbx.Text);
                Classes.Item_List.Bone.amount = int.Parse(bon_txtbx.Text);
                Classes.Item_List.Fiber_Optics.amount = int.Parse(fio_txtbx.Text);
                Classes.Item_List.Ceramic.amount = int.Parse(cer_txtbx.Text);
                Classes.Item_List.Circuitry.amount = int.Parse(crc_txtbx.Text);
                Classes.Item_List.Cloth.amount = int.Parse(clo_txtbx.Text);
                Classes.Item_List.Concrete.amount = int.Parse(con_txtbx.Text);
                Classes.Item_List.Copper.amount = int.Parse(cop_txtbx.Text);
                Classes.Item_List.Cork.amount = int.Parse(cor_txtbx.Text);
                Classes.Item_List.Crystal.amount = int.Parse(cry_txtbx.Text);
                Classes.Item_List.Fertilizer.amount = int.Parse(fer_txtbx.Text);
                Classes.Item_List.Fiberglass.amount = int.Parse(fib_txtbx.Text);
                Classes.Item_List.Gears.amount = int.Parse(grs_txtbx.Text);
                Classes.Item_List.Glass.amount = int.Parse(gls_txtbx.Text);
                Classes.Item_List.Gold.amount = int.Parse(gld_txtbx.Text);
                Classes.Item_List.Lead.amount = int.Parse(led_txtbx.Text);
                Classes.Item_List.Leather.amount = int.Parse(ltr_txtbx.Text);
                Classes.Item_List.Nuclear_Material.amount = int.Parse(num_txtbx.Text);
                Classes.Item_List.Oil.amount = int.Parse(oil_txtbx.Text);
                Classes.Item_List.Plastic.amount = int.Parse(pls_txtbx.Text);
                Classes.Item_List.Rubber.amount = int.Parse(rbr_txtbx.Text);
                Classes.Item_List.Screw.amount = int.Parse(scr_txtbx.Text);
                Classes.Item_List.Silver.amount = int.Parse(slv_txtbx.Text);
                Classes.Item_List.Spring.amount = int.Parse(spr_txtbx.Text);
                Classes.Item_List.Steel.amount = int.Parse(stl_txtbx.Text);
                Classes.Item_List.Wood.amount = int.Parse(wod_txtbx.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("One or more values are not numbers..");
            }

        }

        private void button2_Click(object sender, EventArgs e) // Clear Values Resources
        {
            // Set textboxes to 0 and clears the Item List values for Resources.
            Classes.Item_List.Acid.amount = 0;
            Classes.Item_List.Adhesive.amount = 0;
            Classes.Item_List.Aluminum.amount = 0;
            Classes.Item_List.Antiseptic.amount = 0;
            Classes.Item_List.Asbestos.amount = 0;
            Classes.Item_List.Ballistic_Fiber.amount = 0;
            Classes.Item_List.Bone.amount = 0;
            Classes.Item_List.Fiber_Optics.amount = 0;
            Classes.Item_List.Ceramic.amount = 0;
            Classes.Item_List.Circuitry.amount = 0;
            Classes.Item_List.Cloth.amount = 0;
            Classes.Item_List.Concrete.amount = 0;
            Classes.Item_List.Copper.amount = 0;
            Classes.Item_List.Cork.amount = 0;
            Classes.Item_List.Crystal.amount = 0;
            Classes.Item_List.Fertilizer.amount = 0;
            Classes.Item_List.Fiberglass.amount = 0;
            Classes.Item_List.Gears.amount = 0;
            Classes.Item_List.Glass.amount = 0;
            Classes.Item_List.Gold.amount = 0;
            Classes.Item_List.Lead.amount = 0;
            Classes.Item_List.Leather.amount = 0;
            Classes.Item_List.Nuclear_Material.amount = 0;
            Classes.Item_List.Oil.amount = 0;
            Classes.Item_List.Plastic.amount = 0;
            Classes.Item_List.Rubber.amount = 0;
            Classes.Item_List.Screw.amount = 0;
            Classes.Item_List.Silver.amount = 0;
            Classes.Item_List.Spring.amount = 0;
            Classes.Item_List.Steel.amount = 0;
            Classes.Item_List.Wood.amount = 0;

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

        private void button5_Click(object sender, EventArgs e) // Set Value Corp
        {
            /* Same as Resource set value button, but for food */
            try
            {
                Classes.Item_List.Carrot.amount = int.Parse(crt_txtbx.Text);
                Classes.Item_List.Corn.amount = int.Parse(crn_txtbx.Text);
                Classes.Item_List.Gourd.amount = int.Parse(grd_txtbx.Text);
                Classes.Item_List.Melon.amount = int.Parse(mln_txtbx.Text);
                Classes.Item_List.Mutfruit.amount = int.Parse(mtf_txtbx.Text);
                Classes.Item_List.Razorgrain.amount = int.Parse(rzr_txtbx.Text);
                Classes.Item_List.Tato.amount = int.Parse(tto_txtbx.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("One or more values are not numbers..");
            }
        }

        private void button4_Click(object sender, EventArgs e) // Food Clear
        {
            /* Same as Resource clear values, but.... food */
            Classes.Item_List.Carrot.amount = 0;
            Classes.Item_List.Corn.amount = 0;
            Classes.Item_List.Gourd.amount = 0;
            Classes.Item_List.Melon.amount = 0;
            Classes.Item_List.Mutfruit.amount = 0;
            Classes.Item_List.Razorgrain.amount = 0;
            Classes.Item_List.Tato.amount = 0;

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
            Classes.Item_List.Carrot.amount = 0;
            Classes.Item_List.Corn.amount = 0;
            Classes.Item_List.Gourd.amount = 0;
            Classes.Item_List.Melon.amount = 0;
            Classes.Item_List.Mutfruit.amount = 0;
            Classes.Item_List.Razorgrain.amount = 0;
            Classes.Item_List.Tato.amount = 0;
            Classes.Item_List.Acid.amount = 0;
            Classes.Item_List.Adhesive.amount = 0;
            Classes.Item_List.Aluminum.amount = 0;
            Classes.Item_List.Antiseptic.amount = 0;
            Classes.Item_List.Asbestos.amount = 0;
            Classes.Item_List.Ballistic_Fiber.amount = 0;
            Classes.Item_List.Bone.amount = 0;
            Classes.Item_List.Fiber_Optics.amount = 0;
            Classes.Item_List.Ceramic.amount = 0;
            Classes.Item_List.Circuitry.amount = 0;
            Classes.Item_List.Cloth.amount = 0;
            Classes.Item_List.Concrete.amount = 0;
            Classes.Item_List.Copper.amount = 0;
            Classes.Item_List.Cork.amount = 0;
            Classes.Item_List.Crystal.amount = 0;
            Classes.Item_List.Fertilizer.amount = 0;
            Classes.Item_List.Fiberglass.amount = 0;
            Classes.Item_List.Gears.amount = 0;
            Classes.Item_List.Glass.amount = 0;
            Classes.Item_List.Gold.amount = 0;
            Classes.Item_List.Lead.amount = 0;
            Classes.Item_List.Leather.amount = 0;
            Classes.Item_List.Nuclear_Material.amount = 0;
            Classes.Item_List.Oil.amount = 0;
            Classes.Item_List.Plastic.amount = 0;
            Classes.Item_List.Rubber.amount = 0;
            Classes.Item_List.Screw.amount = 0;
            Classes.Item_List.Silver.amount = 0;
            Classes.Item_List.Spring.amount = 0;
            Classes.Item_List.Steel.amount = 0;
            Classes.Item_List.Wood.amount = 0;

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
            dot308_txtbx.Text = "0";
            dot38_txtbx.Text = "0";
            dot44_txtbx.Text = "0";
            dot45_txtbx.Text = "0";
            dot50_txtbx.Text = "0";
            dot5mm_txtbx.Text = "0";
            dot10mm_txtbx.Text = "0";
            dot556mm_txtbx.Text = "0";
            stg_txtbx.Text = "0";
            rws_txtbx.Text = "0";
            alb_txtbx.Text = "0";
            msl_txtbx.Text = "0";
            flr_txtbx.Text = "0";
            cnb_txtbx.Text = "0";
            gam_txtbx.Text = "0";
            jnk_txtbx.Text = "0";
            cyr_txtbx.Text = "0";
            nrg_txtbx.Text = "0";
            plm_txtbx.Text = "0";
            fusco_txtbx.Text = "0";
            fusce_txtbx.Text = "0";
            EC2mm_txtbx.Text = "0";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // Menu Exit
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Resources
                add2Array(Classes.Item_List.Acid.code, Classes.Item_List.Acid.amount);
                add2Array(Classes.Item_List.Adhesive.code, Classes.Item_List.Adhesive.amount);
                add2Array(Classes.Item_List.Aluminum.code, Classes.Item_List.Aluminum.amount);
                add2Array(Classes.Item_List.Antiseptic.code, Classes.Item_List.Antiseptic.amount);
                add2Array(Classes.Item_List.Asbestos.code, Classes.Item_List.Asbestos.amount);
                add2Array(Classes.Item_List.Ballistic_Fiber.code, Classes.Item_List.Ballistic_Fiber.amount);
                add2Array(Classes.Item_List.Bone.code, Classes.Item_List.Bone.amount);
                add2Array(Classes.Item_List.Fiber_Optics.code, Classes.Item_List.Fiber_Optics.amount);
                add2Array(Classes.Item_List.Ceramic.code, Classes.Item_List.Ceramic.amount);
                add2Array(Classes.Item_List.Circuitry.code, Classes.Item_List.Circuitry.amount);
                add2Array(Classes.Item_List.Cloth.code, Classes.Item_List.Cloth.amount);
                add2Array(Classes.Item_List.Concrete.code, Classes.Item_List.Concrete.amount);
                add2Array(Classes.Item_List.Copper.code, Classes.Item_List.Copper.amount);
                add2Array(Classes.Item_List.Cork.code, Classes.Item_List.Cork.amount);
                add2Array(Classes.Item_List.Crystal.code, Classes.Item_List.Crystal.amount);
                add2Array(Classes.Item_List.Fertilizer.code, Classes.Item_List.Fertilizer.amount);
                add2Array(Classes.Item_List.Fiberglass.code, Classes.Item_List.Fiberglass.amount);
                add2Array(Classes.Item_List.Gears.code, Classes.Item_List.Gears.amount);
                add2Array(Classes.Item_List.Glass.code, Classes.Item_List.Glass.amount);
                add2Array(Classes.Item_List.Gold.code, Classes.Item_List.Gold.amount);
                add2Array(Classes.Item_List.Lead.code, Classes.Item_List.Lead.amount);
                add2Array(Classes.Item_List.Leather.code, Classes.Item_List.Leather.amount);
                add2Array(Classes.Item_List.Nuclear_Material.code, Classes.Item_List.Nuclear_Material.amount);
                add2Array(Classes.Item_List.Oil.code, Classes.Item_List.Oil.amount);
                add2Array(Classes.Item_List.Plastic.code, Classes.Item_List.Plastic.amount);
                add2Array(Classes.Item_List.Rubber.code, Classes.Item_List.Rubber.amount);
                add2Array(Classes.Item_List.Screw.code, Classes.Item_List.Screw.amount);
                add2Array(Classes.Item_List.Silver.code, Classes.Item_List.Silver.amount);
                add2Array(Classes.Item_List.Spring.code, Classes.Item_List.Spring.amount);
                add2Array(Classes.Item_List.Steel.code, Classes.Item_List.Steel.amount);
                add2Array(Classes.Item_List.Wood.code, Classes.Item_List.Wood.amount);

                // Crops
                add2Array(Classes.Item_List.Carrot.code, Classes.Item_List.Carrot.amount);
                add2Array(Classes.Item_List.Corn.code, Classes.Item_List.Corn.amount);
                add2Array(Classes.Item_List.Gourd.code, Classes.Item_List.Gourd.amount);
                add2Array(Classes.Item_List.Melon.code, Classes.Item_List.Melon.amount);
                add2Array(Classes.Item_List.Mutfruit.code, Classes.Item_List.Mutfruit.amount);
                add2Array(Classes.Item_List.Razorgrain.code, Classes.Item_List.Razorgrain.amount);
                add2Array(Classes.Item_List.Tato.code, Classes.Item_List.Tato.amount);

                // Ammo
                add2Array(Classes.Item_List.ammo_dot308.code,Classes.Item_List.ammo_dot308.amount);
                add2Array(Classes.Item_List.ammo_dot38.code, Classes.Item_List.ammo_dot38.amount);
                add2Array(Classes.Item_List.ammo_dot44.code, Classes.Item_List.ammo_dot44.amount);
                add2Array(Classes.Item_List.ammo_dot45.code, Classes.Item_List.ammo_dot45.amount);
                add2Array(Classes.Item_List.ammo_dot50_calibeammo.code, Classes.Item_List.ammo_dot50_calibeammo.amount);
                add2Array(Classes.Item_List.ammo_dot5mm.code, Classes.Item_List.ammo_dot5mm.amount);
                add2Array(Classes.Item_List.ammo_dot10mm.code, Classes.Item_List.ammo_dot10mm.amount);
                add2Array(Classes.Item_List.ammo_5dot56mm.code, Classes.Item_List.ammo_5dot56mm.amount);
                add2Array(Classes.Item_List.ammo_shotgun_shell.code, Classes.Item_List.ammo_shotgun_shell.amount);
                add2Array(Classes.Item_List.ammo_Railway_spike.code, Classes.Item_List.ammo_Railway_spike.amount);
                add2Array(Classes.Item_List.ammo_Alien_b.code, Classes.Item_List.ammo_Alien_b.amount);
                add2Array(Classes.Item_List.ammo_missile.code, Classes.Item_List.ammo_missile.amount);
                add2Array(Classes.Item_List.ammo_flare.code, Classes.Item_List.ammo_flare.amount);
                add2Array(Classes.Item_List.ammo_cannonball.code, Classes.Item_List.ammo_cannonball.amount);
                add2Array(Classes.Item_List.ammo_Gamma.code, Classes.Item_List.ammo_Gamma.amount);
                add2Array(Classes.Item_List.ammo_junk.code, Classes.Item_List.ammo_junk.amount);
                add2Array(Classes.Item_List.ammo_Cyro_cell.code, Classes.Item_List.ammo_Cyro_cell.amount);
                add2Array(Classes.Item_List.ammo_Energy_cell.code, Classes.Item_List.ammo_Energy_cell.amount);
                add2Array(Classes.Item_List.ammo_Plasma_cart.code, Classes.Item_List.ammo_Plasma_cart.amount);
                add2Array(Classes.Item_List.ammo_Fusion_core.code, Classes.Item_List.ammo_Fusion_core.amount);
                add2Array(Classes.Item_List.ammo_Fusion_cell.code, Classes.Item_List.ammo_Fusion_cell.amount);
                add2Array(Classes.Item_List.ammo_2mm_EC.code,Classes.Item_List.ammo_2mm_EC.amount);
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't add items to the hash");
            }

            SaveFileDialog saving = new SaveFileDialog();

            saving.Filter = "Text File|*.txt";
            saving.ShowDialog();
            StreamWriter saver = new StreamWriter(saving.FileName);
            foreach (var line in Classes.Item_List.Final.ToArray())
            {
                //MessageBox.Show(line.ToString());
                saver.WriteLine(line.ToString());
            }
            saver.Dispose();
            saver.Close();
            MessageBox.Show("File Saved.");
        }

        private void ammo_set_Click(object sender, EventArgs e) // Set Value Ammo
        {
            try
            {
                Classes.Item_List.ammo_dot308.amount = int.Parse(dot308_txtbx.Text);
                Classes.Item_List.ammo_dot38.amount = int.Parse(dot38_txtbx.Text);
                Classes.Item_List.ammo_dot44.amount = int.Parse(dot44_txtbx.Text);
                Classes.Item_List.ammo_dot45.amount = int.Parse(dot45_txtbx.Text);
                Classes.Item_List.ammo_dot50_calibeammo.amount = int.Parse(dot50_txtbx.Text);
                Classes.Item_List.ammo_dot5mm.amount = int.Parse(dot5mm_txtbx.Text);
                Classes.Item_List.ammo_dot10mm.amount = int.Parse(dot10mm_txtbx.Text);
                Classes.Item_List.ammo_5dot56mm.amount = int.Parse(dot556mm_txtbx.Text);
                Classes.Item_List.ammo_shotgun_shell.amount = int.Parse(stg_txtbx.Text);
                Classes.Item_List.ammo_Railway_spike.amount = int.Parse(rws_txtbx.Text);
                Classes.Item_List.ammo_Alien_b.amount = int.Parse(alb_txtbx.Text);
                Classes.Item_List.ammo_missile.amount = int.Parse(msl_txtbx.Text);
                Classes.Item_List.ammo_flare.amount = int.Parse(flr_txtbx.Text);
                Classes.Item_List.ammo_cannonball.amount = int.Parse(cnb_txtbx.Text);
                Classes.Item_List.ammo_Gamma.amount = int.Parse(gam_txtbx.Text);
                Classes.Item_List.ammo_junk.amount = int.Parse(jnk_txtbx.Text);
                Classes.Item_List.ammo_Cyro_cell.amount = int.Parse(cyr_txtbx.Text);
                Classes.Item_List.ammo_Energy_cell.amount = int.Parse(nrg_txtbx.Text);
                Classes.Item_List.ammo_Plasma_cart.amount = int.Parse(plm_txtbx.Text);
                Classes.Item_List.ammo_Fusion_core.amount = int.Parse(fusco_txtbx.Text);
                Classes.Item_List.ammo_Fusion_cell.amount = int.Parse(fusce_txtbx.Text);
                Classes.Item_List.ammo_2mm_EC.amount = int.Parse(EC2mm_txtbx.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("One or more values are not numbers..");
            }
            
        }

        private void ammo_clear_Click(object sender, EventArgs e) // Ammo Clear
        {
            Classes.Item_List.ammo_dot308.amount = 0;
            Classes.Item_List.ammo_dot38.amount = 0;
            Classes.Item_List.ammo_dot44.amount = 0;
            Classes.Item_List.ammo_dot45.amount = 0;
            Classes.Item_List.ammo_dot50_calibeammo.amount = 0;
            Classes.Item_List.ammo_dot5mm.amount = 0;
            Classes.Item_List.ammo_dot10mm.amount = 0;
            Classes.Item_List.ammo_5dot56mm.amount = 0;
            Classes.Item_List.ammo_shotgun_shell.amount = 0;
            Classes.Item_List.ammo_Railway_spike.amount = 0;
            Classes.Item_List.ammo_Alien_b.amount = 0;
            Classes.Item_List.ammo_missile.amount = 0;
            Classes.Item_List.ammo_flare.amount = 0;
            Classes.Item_List.ammo_cannonball.amount = 0;
            Classes.Item_List.ammo_Gamma.amount = 0;
            Classes.Item_List.ammo_junk.amount = 0;
            Classes.Item_List.ammo_Cyro_cell.amount = 0;
            Classes.Item_List.ammo_Energy_cell.amount = 0;
            Classes.Item_List.ammo_Plasma_cart.amount = 0;
            Classes.Item_List.ammo_Fusion_core.amount = 0;
            Classes.Item_List.ammo_Fusion_cell.amount = 0;
            Classes.Item_List.ammo_2mm_EC.amount = 0;

            dot308_txtbx.Text= "0";
            dot38_txtbx.Text= "0";
            dot44_txtbx.Text= "0";
            dot45_txtbx.Text= "0";
            dot50_txtbx.Text= "0";
            dot5mm_txtbx.Text= "0";
            dot10mm_txtbx.Text= "0";
            dot556mm_txtbx.Text= "0";
            stg_txtbx.Text= "0";
            rws_txtbx.Text= "0";
            alb_txtbx.Text= "0";
            msl_txtbx.Text= "0";
            flr_txtbx.Text= "0";
            cnb_txtbx.Text= "0";
            gam_txtbx.Text= "0";
            jnk_txtbx.Text= "0";
            cyr_txtbx.Text= "0";
            nrg_txtbx.Text= "0";
            plm_txtbx.Text= "0";
            fusco_txtbx.Text= "0";
            fusce_txtbx.Text= "0";
            EC2mm_txtbx.Text= "0";
        }
    }
}