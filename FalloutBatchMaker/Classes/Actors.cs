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

    public static class Actor_List
    {
        // Mobs
        public static Object Ghoul = new Object { code = "758AD", amount = 0, };
        public static Object Raider = new Object { code = "4AF21", amount = 0, };
        public static Object Super_Mutant = new Object { code = "A1471", amount = 0, };
        public static Object Brahmin = new Object { code = "20480", amount = 0, };
        public static Object Mole_rat = new Object { code = "1A966", amount = 0, };
        public static Object Mongle = new Object { code = "1D1SA", amount = 0, };
        public static Object Mutant_hound = new Object { code = "9OC37", amount = 0, };
        public static Object Radstag = new Object { code = "8CA3C", amount = 0, };
        public static Object Yao_Guai = new Object { code = "AOF33", amount = 0, };
        public static Object Deathclaw = new Object { code = "1DB4C", amount = 0, };
        public static Object Bloatfly = new Object { code = "29469", amount = 0, };
        public static Object Bloodbug = new Object { code = "28669", amount = 0, };
        public static Object Mirelurk = new Object { code = "24002", amount = 0, };
        public static Object Stingwing = new Object { code = "5FBB3", amount = 0, };
        public static Object Radroach = new Object { code = "475DF", amount = 0, };
        public static Object Radscorpion = new Object { code = "636AA", amount = 0, };
        public static Object Alien = new Object { code = "184C51", amount = 0, };
        public static Object Glowing_mole_rat = new Object { code = "ff0044E0", amount = 0, };
        public static Object Dog = new Object { code = "1d162", amount = 0, };

        
        //etc
        public static ArrayList Final = new ArrayList();
    }
}
