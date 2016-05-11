using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FalloutBatchMaker.Classes
{
    class Functionality // For Arrays and such
    {
        public static List<string> Final_Items = new List<string>();
        public static List<string> Final_Actors = new List<string>();

        public void ClearLists()
        {
            Final_Actors.Clear();
            Final_Items.Clear();
        }

        public void add2Items(string item, int value) // Add to Items List
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
        public void add2Actors(string item, int value) // Add to Actors list
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

        public void add2Perks(string item, int value) // Add to Perks Array
        {
            if (value > 0)
            {
                try
                {
                    Classes.Functionality.Final_Perks.Add("player.addperk " + item + " " + value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }

}
