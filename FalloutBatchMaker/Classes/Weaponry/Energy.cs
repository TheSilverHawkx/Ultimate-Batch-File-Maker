using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalloutBatchMaker.Classes.Weaponry
{
    class Energy
    {
        // Laser
        public static Object musket_lsr = new Object { code = "0001dacf", amount = 0, };
        public static Object pistol_lsr = new Object { code = "0009983b", amount = 0, };
        public static Object rifle_lsr = new Object { code = "0009983b", amount = 0, };
        public static Object gatling_lsr = new Object { code = "000e27bc", amount = 0, };

        // Plasma
        public static Object pistol_pls = new Object { code = "00100ae9", amount = 0, };
        public static Object rifle_pls = new Object { code = "00100ae9", amount = 0, };
        public static Object scater_pls = new Object { code = "00100ae9", amount = 0, };
        public static Object sniper_pls = new Object { code = "00100ae9", amount = 0, };
        public static Object thrower_pls = new Object { code = "00100ae9", amount = 0, };

        // Other
        public static Object Gamma = new Object { code = "000ddb7c", amount = 0, };
        public static Object Gauss = new Object { code = "000d1eb0", amount = 0, };
        public static Object Alien = new Object { code = "000ff995", amount = 0, };
        public static Object Cryolator = new Object { code = "00171b2b", amount = 0, };

    }
}
