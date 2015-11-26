using System.Collections;

namespace FalloutBatchMaker.Classes
{
    public class Object
    {
        public string code;
        public int amount;
    }

    public static class Item_List
    {
        // Ammo
        public static Object ammo_dot308 = new Object { code = "0001f66b", amount = 0, };
        public static Object ammo_dot38 = new Object { code = "0004ce87", amount = 0, };
        public static Object ammo_dot44 = new Object { code = "0009221c", amount = 0, };
        public static Object ammo_dot45 = new Object { code = "0001f66a", amount = 0, };
        public static Object ammo_dot50_calibeammo = new Object { code = "0001f279", amount = 0, };
        public static Object ammo_dot10mm = new Object { code = "0001f276", amount = 0, };
        public static Object ammo_dot5mm = new Object { code = "0001f66c", amount = 0, };
        public static Object ammo_5dot56mm = new Object { code = "0001f278", amount = 0, };
        public static Object ammo_shotgun_shell = new Object { code = "0001f673", amount = 0, };
        public static Object ammo_Railway_spike = new Object { code = "000fe269", amount = 0, };
        public static Object ammo_Cyro_cell = new Object { code = "0018abe2", amount = 0, };
        public static Object ammo_Energy_cell = new Object { code = "000c1897", amount = 0, };
        public static Object ammo_Plasma_cart = new Object { code = "0001dbb7", amount = 0, };
        public static Object ammo_Fusion_core = new Object { code = "00075fe4", amount = 0, };
        public static Object ammo_Fusion_cell = new Object { code = "000c1897", amount = 0, };
        public static Object ammo_2mm_EC = new Object { code = "0018abdf", amount = 0, };
        public static Object ammo_Gamma = new Object { code = "000df279", amount = 0, };
        public static Object ammo_Alien_b = new Object { code = "001025aa", amount = 0, };
        public static Object ammo_missile = new Object { code = "000caba3", amount = 0, };
        public static Object ammo_flare = new Object { code = "001025ae", amount = 0, };
        public static Object ammo_junk = new Object { code = "000e942c", amount = 0, };
        public static Object ammo_cannonball = new Object { code = "000fd11c", amount = 0, };

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
        
        //Consumables
        public static Object Bloafy_Meat = new Object { code = "000330f4", amount = 0, };
        public static Object Brahmin_Meat = new Object { code = "0004a13f", amount = 0, };
        public static Object Cram = new Object { code = "000330ee", amount = 0, };
        public static Object Deathclaw_Meat = new Object { code = "00074d0e", amount = 0, };
        public static Object Porks_Beans = new Object { code = "000330f0", amount = 0, };
        public static Object Salsbury_Steak = new Object { code = "000366ba", amount = 0, };
        public static Object Sugar_Bombs = new Object { code = "000330f2", amount = 0, };
        public static Object Blood_Pack = new Object { code = "00052409", amount = 0, };
        public static Object Dirty_Water = new Object { code = "000366bf", amount = 0, };
        public static Object Nuka_Cola = new Object { code = "0004835d", amount = 0, };
        public static Object Nuka_Quantum = new Object { code = "0004835f", amount = 0, };
        public static Object Purified_Water = new Object { code = "000366c0", amount = 0, };
        public static Object Beer = new Object { code = "0011ea93", amount = 0, };
        public static Object Whisky = new Object { code = "000366c1", amount = 0, };
        public static Object Wine = new Object { code = "000366c2", amount = 0, };
        public static Object Buffout = new Object { code = "00033778", amount = 0, };
        public static Object Jet = new Object { code = "000366c5", amount = 0, };
        public static Object Med_X = new Object { code = "00033779", amount = 0, };
        public static Object Mentats = new Object { code = "0003377b", amount = 0, };
        public static Object Psycho = new Object { code = "0003377d", amount = 0, };
        public static Object Rad_X = new Object { code = "00024057", amount = 0, };
        public static Object Rad_Away = new Object { code = "00023742", amount = 0, };
        public static Object Stimpack = new Object { code = "00023736", amount = 0, };
        
       
    }
}
