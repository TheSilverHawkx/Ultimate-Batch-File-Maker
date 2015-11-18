using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalloutBatchMaker.Classes
{
    public class Object
    {
        public string code;
        public int amount;
    }

    public static class Item_List
    {
        // Resources
        public static Object Acid = new Object { code = "001BF72D", amount = 0, };
        public static Object Adhesive = new Object { code = "001BF72E", amount = 0, };
        public static Object Aluminum = new Object { code = "0006907A", amount = 0, };
        public static Object Antiseptic = new Object { code = "001BF72F", amount = 0, };
        public static Object Asbestos = new Object { code = "000AEC5C", amount = 0, };
        public static Object Ballistic_Fiber = new Object { code = "000AEC5B", amount = 0, };
        public static Object Bone = new Object { code = "000AEC5D", amount = 0, };
        public static Object Ceramic = new Object { code = "000AEC5E", amount = 0, };
        public static Object Circuitry = new Object { code = "0006907B", amount = 0, };
        public static Object Cloth = new Object { code = "000AEC5F", amount = 0, };
        public static Object Concrete = new Object { code = "00106D99", amount = 0, };
        public static Object Copper = new Object { code = "0006907C", amount = 0, };
        public static Object Cork = new Object { code = "000AEC60", amount = 0, };
        public static Object Crystal = new Object { code = "0006907D", amount = 0, };
        public static Object Fertilizer = new Object { code = "001BF730", amount = 0, };
        public static Object Fiber_Optics = new Object { code = "00069087", amount = 0, };
        public static Object Fiberglass = new Object { code = "000AEC61", amount = 0, };
        public static Object Gears = new Object { code = "0006907E", amount = 0, };
        public static Object Glass = new Object { code = "00069085", amount = 0, };
        public static Object Gold = new Object { code = "000AEC62", amount = 0, };
        public static Object Lead = new Object { code = "000AEC63", amount = 0, };
        public static Object Leather = new Object { code = "000AEC64", amount = 0, };
        public static Object Nuclear_Material = new Object { code = "00069086", amount = 0, };
        public static Object Oil = new Object { code = "001BF732", amount = 0, };
        public static Object Plastic = new Object { code = "0006907F", amount = 0, };
        public static Object Rubber = new Object { code = "00106D98", amount = 0, };
        public static Object Screw = new Object { code = "00069081", amount = 0, };
        public static Object Silver = new Object { code = "000AEC66", amount = 0, };
        public static Object Spring = new Object { code = "00069082", amount = 0, };
        public static Object Steel = new Object { code = "000731A4", amount = 0, };
        public static Object Wood = new Object { code = "000731A3", amount = 0, };

        //Crops
        public static Object Carrot = new Object { code = "000F742E", amount = 0, };
        public static Object Corn = new Object { code = "000330F8", amount = 0, };
        public static Object Gourd = new Object { code = "000EF24D", amount = 0, };
        public static Object Melon = new Object { code = "000FAFEB", amount = 0, };
        public static Object Mutfruit = new Object { code = "000d3EA7", amount = 0, };
        public static Object Razorgrain = new Object { code = "000E0043", amount = 0, };
        public static Object Tato = new Object { code = "009DCC4", amount = 0, };

        //etc
        public static ArrayList Final = new ArrayList();
    }
}
