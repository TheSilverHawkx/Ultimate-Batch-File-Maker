using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

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
            Classes.Actor_List.Ghoul.amount = 0;
            Classes.Actor_List.Raider.amount = 0;
            Classes.Actor_List.Super_Mutant.amount = 0;
            Classes.Actor_List.Brahmin.amount = 0;
            Classes.Actor_List.Mole_rat.amount = 0;
            Classes.Actor_List.Mongle.amount = 0;
            Classes.Actor_List.Mutant_hound.amount = 0;
            Classes.Actor_List.Radstag.amount = 0;
            Classes.Actor_List.Yao_Guai.amount = 0;
            Classes.Actor_List.Deathclaw.amount = 0;
            Classes.Actor_List.Bloatfly.amount = 0;
            Classes.Actor_List.Bloodbug.amount = 0;
            Classes.Actor_List.Mirelurk.amount = 0;
            Classes.Actor_List.Stingwing.amount = 0;
            Classes.Actor_List.Radroach.amount = 0;
            Classes.Actor_List.Radscorpion.amount = 0;
            Classes.Actor_List.Alien.amount = 0;
            Classes.Actor_List.Dog.amount = 0;

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
            ghl_txtbx.Text = "0";
            rdr_txtbx.Text = "0";
            spm_txtbx.Text = "0";
            brm_txtbx.Text = "0";
            mlr_txtbx.Text = "0";
            mng_txtbx.Text = "0";
            mth_txtbx.Text = "0";
            rds_txtbx.Text = "0";
            yag_txtbx.Text = "0";
            dtc_txtbx.Text = "0";
            blf_txtbx.Text = "0";
            blb_txtbx.Text = "0";
            mrl_txtbx.Text = "0";
            stw_txtbx.Text = "0";
            rdro_txtbx.Text = "0";
            rdrsctxtbx.Text = "0";
            alb_txtbx.Text = "0";
            dog_txtbx.Text = "0";

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
            Classes.Functionality functions = new Classes.Functionality();
            try
            {
                // Resources
                functions.add2Items(Classes.Item_List.Acid.code, Classes.Item_List.Acid.amount);
                functions.add2Items(Classes.Item_List.Adhesive.code, Classes.Item_List.Adhesive.amount);
                functions.add2Items(Classes.Item_List.Aluminum.code, Classes.Item_List.Aluminum.amount);
                functions.add2Items(Classes.Item_List.Antiseptic.code, Classes.Item_List.Antiseptic.amount);
                functions.add2Items(Classes.Item_List.Asbestos.code, Classes.Item_List.Asbestos.amount);
                functions.add2Items(Classes.Item_List.Ballistic_Fiber.code, Classes.Item_List.Ballistic_Fiber.amount);
                functions.add2Items(Classes.Item_List.Bone.code, Classes.Item_List.Bone.amount);
                functions.add2Items(Classes.Item_List.Fiber_Optics.code, Classes.Item_List.Fiber_Optics.amount);
                functions.add2Items(Classes.Item_List.Ceramic.code, Classes.Item_List.Ceramic.amount);
                functions.add2Items(Classes.Item_List.Circuitry.code, Classes.Item_List.Circuitry.amount);
                functions.add2Items(Classes.Item_List.Cloth.code, Classes.Item_List.Cloth.amount);
                functions.add2Items(Classes.Item_List.Concrete.code, Classes.Item_List.Concrete.amount);
                functions.add2Items(Classes.Item_List.Copper.code, Classes.Item_List.Copper.amount);
                functions.add2Items(Classes.Item_List.Cork.code, Classes.Item_List.Cork.amount);
                functions.add2Items(Classes.Item_List.Crystal.code, Classes.Item_List.Crystal.amount);
                functions.add2Items(Classes.Item_List.Fertilizer.code, Classes.Item_List.Fertilizer.amount);
                functions.add2Items(Classes.Item_List.Fiberglass.code, Classes.Item_List.Fiberglass.amount);
                functions.add2Items(Classes.Item_List.Gears.code, Classes.Item_List.Gears.amount);
                functions.add2Items(Classes.Item_List.Glass.code, Classes.Item_List.Glass.amount);
                functions.add2Items(Classes.Item_List.Gold.code, Classes.Item_List.Gold.amount);
                functions.add2Items(Classes.Item_List.Lead.code, Classes.Item_List.Lead.amount);
                functions.add2Items(Classes.Item_List.Leather.code, Classes.Item_List.Leather.amount);
                functions.add2Items(Classes.Item_List.Nuclear_Material.code, Classes.Item_List.Nuclear_Material.amount);
                functions.add2Items(Classes.Item_List.Oil.code, Classes.Item_List.Oil.amount);
                functions.add2Items(Classes.Item_List.Plastic.code, Classes.Item_List.Plastic.amount);
                functions.add2Items(Classes.Item_List.Rubber.code, Classes.Item_List.Rubber.amount);
                functions.add2Items(Classes.Item_List.Screw.code, Classes.Item_List.Screw.amount);
                functions.add2Items(Classes.Item_List.Silver.code, Classes.Item_List.Silver.amount);
                functions.add2Items(Classes.Item_List.Spring.code, Classes.Item_List.Spring.amount);
                functions.add2Items(Classes.Item_List.Steel.code, Classes.Item_List.Steel.amount);
                functions.add2Items(Classes.Item_List.Wood.code, Classes.Item_List.Wood.amount);

                // Crops
                functions.add2Items(Classes.Item_List.Carrot.code, Classes.Item_List.Carrot.amount);
                functions.add2Items(Classes.Item_List.Corn.code, Classes.Item_List.Corn.amount);
                functions.add2Items(Classes.Item_List.Gourd.code, Classes.Item_List.Gourd.amount);
                functions.add2Items(Classes.Item_List.Melon.code, Classes.Item_List.Melon.amount);
                functions.add2Items(Classes.Item_List.Mutfruit.code, Classes.Item_List.Mutfruit.amount);
                functions.add2Items(Classes.Item_List.Razorgrain.code, Classes.Item_List.Razorgrain.amount);
                functions.add2Items(Classes.Item_List.Tato.code, Classes.Item_List.Tato.amount);

                // Ammo
                functions.add2Items(Classes.Item_List.ammo_dot308.code,Classes.Item_List.ammo_dot308.amount);
                functions.add2Items(Classes.Item_List.ammo_dot38.code, Classes.Item_List.ammo_dot38.amount);
                functions.add2Items(Classes.Item_List.ammo_dot44.code, Classes.Item_List.ammo_dot44.amount);
                functions.add2Items(Classes.Item_List.ammo_dot45.code, Classes.Item_List.ammo_dot45.amount);
                functions.add2Items(Classes.Item_List.ammo_dot50_calibeammo.code, Classes.Item_List.ammo_dot50_calibeammo.amount);
                functions.add2Items(Classes.Item_List.ammo_dot5mm.code, Classes.Item_List.ammo_dot5mm.amount);
                functions.add2Items(Classes.Item_List.ammo_dot10mm.code, Classes.Item_List.ammo_dot10mm.amount);
                functions.add2Items(Classes.Item_List.ammo_5dot56mm.code, Classes.Item_List.ammo_5dot56mm.amount);
                functions.add2Items(Classes.Item_List.ammo_shotgun_shell.code, Classes.Item_List.ammo_shotgun_shell.amount);
                functions.add2Items(Classes.Item_List.ammo_Railway_spike.code, Classes.Item_List.ammo_Railway_spike.amount);
                functions.add2Items(Classes.Item_List.ammo_Alien_b.code, Classes.Item_List.ammo_Alien_b.amount);
                functions.add2Items(Classes.Item_List.ammo_missile.code, Classes.Item_List.ammo_missile.amount);
                functions.add2Items(Classes.Item_List.ammo_flare.code, Classes.Item_List.ammo_flare.amount);
                functions.add2Items(Classes.Item_List.ammo_cannonball.code, Classes.Item_List.ammo_cannonball.amount);
                functions.add2Items(Classes.Item_List.ammo_Gamma.code, Classes.Item_List.ammo_Gamma.amount);
                functions.add2Items(Classes.Item_List.ammo_junk.code, Classes.Item_List.ammo_junk.amount);
                functions.add2Items(Classes.Item_List.ammo_Cyro_cell.code, Classes.Item_List.ammo_Cyro_cell.amount);
                functions.add2Items(Classes.Item_List.ammo_Energy_cell.code, Classes.Item_List.ammo_Energy_cell.amount);
                functions.add2Items(Classes.Item_List.ammo_Plasma_cart.code, Classes.Item_List.ammo_Plasma_cart.amount);
                functions.add2Items(Classes.Item_List.ammo_Fusion_core.code, Classes.Item_List.ammo_Fusion_core.amount);
                functions.add2Items(Classes.Item_List.ammo_Fusion_cell.code, Classes.Item_List.ammo_Fusion_cell.amount);
                functions.add2Items(Classes.Item_List.ammo_2mm_EC.code,Classes.Item_List.ammo_2mm_EC.amount);

                // Mobs
                functions.add2Actors(Classes.Actor_List.Ghoul.code ,Classes.Actor_List.Ghoul.amount);
                functions.add2Actors(Classes.Actor_List.Raider.code, Classes.Actor_List.Raider.amount);
                functions.add2Actors(Classes.Actor_List.Super_Mutant.code, Classes.Actor_List.Super_Mutant.amount);
                functions.add2Actors(Classes.Actor_List.Brahmin.code, Classes.Actor_List.Brahmin.amount);
                functions.add2Actors(Classes.Actor_List.Mole_rat.code, Classes.Actor_List.Mole_rat.amount);
                functions.add2Actors(Classes.Actor_List.Mongle.code, Classes.Actor_List.Mongle.amount);
                functions.add2Actors(Classes.Actor_List.Mutant_hound.code, Classes.Actor_List.Mutant_hound.amount);
                functions.add2Actors(Classes.Actor_List.Radstag.code, Classes.Actor_List.Radstag.amount);
                functions.add2Actors(Classes.Actor_List.Yao_Guai.code, Classes.Actor_List.Yao_Guai.amount);
                functions.add2Actors(Classes.Actor_List.Deathclaw.code, Classes.Actor_List.Deathclaw.amount);
                functions.add2Actors(Classes.Actor_List.Bloatfly.code, Classes.Actor_List.Bloatfly.amount);
                functions.add2Actors(Classes.Actor_List.Bloodbug.code, Classes.Actor_List.Bloodbug.amount);
                functions.add2Actors(Classes.Actor_List.Mirelurk.code, Classes.Actor_List.Mirelurk.amount);
                functions.add2Actors(Classes.Actor_List.Stingwing.code, Classes.Actor_List.Stingwing.amount);
                functions.add2Actors(Classes.Actor_List.Radroach.code, Classes.Actor_List.Radroach.amount);
                functions.add2Actors(Classes.Actor_List.Radscorpion.code, Classes.Actor_List.Radscorpion.amount);
                functions.add2Actors(Classes.Actor_List.Alien.code, Classes.Actor_List.Alien.amount);
                functions.add2Actors(Classes.Actor_List.Dog.code, Classes.Actor_List.Dog.amount);
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't add items to the hash");
            }

            SaveFileDialog saving = new SaveFileDialog();

            saving.Filter = "Text File|*.txt";
            DialogResult result = saving.ShowDialog();
            if (result == DialogResult.OK)
                {
            StreamWriter saver = new StreamWriter(saving.FileName);
            foreach (var line in Classes.Functionality.Final_Items)
            {
                if (line != String.Empty)
                saver.WriteLine(line);
            }

            foreach (var line in Classes.Functionality.Final_Actors)
            {
                if (line != String.Empty)
                saver.WriteLine(line);
            }
                
            
            functions.ClearArrays();
            saver.Dispose();
            saver.Close();
            MessageBox.Show("File Saved.");
                }
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

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Set Values > Click set > File>Save");
        }

        private void Mobs_set_btn_Click(object sender, EventArgs e)
        {
            Classes.Actor_List.Ghoul.amount = int.Parse(ghl_txtbx.Text);
            Classes.Actor_List.Raider.amount = int.Parse(rdr_txtbx.Text);
            Classes.Actor_List.Super_Mutant.amount = int.Parse(spm_txtbx.Text);
            Classes.Actor_List.Brahmin.amount = int.Parse(brm_txtbx.Text);
            Classes.Actor_List.Mole_rat.amount = int.Parse(mlr_txtbx.Text);
            Classes.Actor_List.Mongle.amount = int.Parse(mng_txtbx.Text);
            Classes.Actor_List.Mutant_hound.amount = int.Parse(mth_txtbx.Text);
            Classes.Actor_List.Radstag.amount = int.Parse(rds_txtbx.Text);
            Classes.Actor_List.Yao_Guai.amount = int.Parse(yag_txtbx.Text);
            Classes.Actor_List.Deathclaw.amount = int.Parse(dtc_txtbx.Text);
            Classes.Actor_List.Bloatfly.amount = int.Parse(blf_txtbx.Text);
            Classes.Actor_List.Bloodbug.amount = int.Parse(blb_txtbx.Text);
            Classes.Actor_List.Mirelurk.amount = int.Parse(mrl_txtbx.Text);
            Classes.Actor_List.Stingwing.amount = int.Parse(stw_txtbx.Text);
            Classes.Actor_List.Radroach.amount = int.Parse(rdro_txtbx.Text);
            Classes.Actor_List.Radscorpion.amount = int.Parse(rdrsctxtbx.Text);
            Classes.Actor_List.Alien.amount = int.Parse(alm_txtbx.Text);
            Classes.Actor_List.Dog.amount = int.Parse(dog_txtbx.Text);
        }

        public void Mob_clear_btn_Click(object sender, EventArgs e)
        {
            Classes.Actor_List.Ghoul.amount = 0;
            Classes.Actor_List.Raider.amount = 0;
            Classes.Actor_List.Super_Mutant.amount = 0;
            Classes.Actor_List.Brahmin.amount = 0;
            Classes.Actor_List.Mole_rat.amount = 0;
            Classes.Actor_List.Mongle.amount = 0;
            Classes.Actor_List.Mutant_hound.amount = 0;
            Classes.Actor_List.Radstag.amount = 0;
            Classes.Actor_List.Yao_Guai.amount = 0;
            Classes.Actor_List.Deathclaw.amount = 0;
            Classes.Actor_List.Bloatfly.amount = 0;
            Classes.Actor_List.Bloodbug.amount = 0;
            Classes.Actor_List.Mirelurk.amount = 0;
            Classes.Actor_List.Stingwing.amount = 0;
            Classes.Actor_List.Radroach.amount = 0;
            Classes.Actor_List.Radscorpion.amount = 0;
            Classes.Actor_List.Alien.amount = 0;
            Classes.Actor_List.Dog.amount = 0;

            ghl_txtbx.Text = "0";
            rdr_txtbx.Text = "0";
            spm_txtbx.Text = "0";
            brm_txtbx.Text = "0";
            mlr_txtbx.Text = "0";
            mng_txtbx.Text = "0";
            mth_txtbx.Text = "0";
            rds_txtbx.Text = "0";
            yag_txtbx.Text = "0";
            dtc_txtbx.Text = "0";
            blf_txtbx.Text = "0";
            blb_txtbx.Text = "0";
            mrl_txtbx.Text = "0";
            stw_txtbx.Text = "0";
            rdro_txtbx.Text = "0";
            rdrsctxtbx.Text = "0";
            alb_txtbx.Text = "0";
            dog_txtbx.Text = "0";
        }
    }
}
