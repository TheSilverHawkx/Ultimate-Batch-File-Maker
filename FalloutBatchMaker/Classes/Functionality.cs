using System;
using System.Collections;

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
    }
}
