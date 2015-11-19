using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FalloutBatchMaker.Classes
{
    class Functionality // For Arrays and such
    {
        public static ArrayList Final_Items = new ArrayList();
        public static ArrayList Final_Actors = new ArrayList();

        public void ClearArrays()
        {
            Final_Actors.Clear();
            Final_Items.Clear();
        }

        public void add2Items(string item, int value) // Add to Items Array
        {
            if (value > 0)
            {
                try
                {
                    Classes.Functionality.Final_Items.Add("player.additem " + item + " " + value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
        public void add2Actors(string item, int value) // Add to Actors Array
        {
            if (value > 0)
            {
                try
                {
                    Classes.Functionality.Final_Actors.Add("placeatme " + item + " " + value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }


        /*public void ClearAll(List<TextBox> txtbx)
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
        }*/
        /* FOR LATER USE

            List<TextBox> textboxes = new List<TextBox>();

            foreach (Control box in this.Controls)
            {
                if (box is TextBox)
                {
                    textboxes.Add((TextBox)box);
                }
            }
            Classes.Functionality functions = new Classes.Functionality();

            functions.ClearAll(textboxes);
        
            try
            {
                foreach (TextBox box in txtbx)
                {

                    box.Text = "0";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("can't do that");
            }
        */
    }
}
