using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalloutBatchMaker
{
    class Definitions
    {
        private string AddCommand { get; set; }
        private string SetVarCommand { get; set; }
        private string AddPerkCommand { get; set; }
        private string SpawnCommand { get; set; }
        private string SetLevelCommand { get; set; }
        private string MapMarkersCommand { get; set; }
        public string GameName { get; set; }
        private Dictionary<string, string> Association = new Dictionary<string, string>();

        public Definitions(string gname, string add, string setV, string addP, string spawn, string setlvl, string mapcomm)
        {
            GameName = gname;
            AddCommand = add;
            SetVarCommand = setV;
            AddPerkCommand = addP;
            SpawnCommand = spawn;
            SetLevelCommand = setlvl;
            MapMarkersCommand = mapcomm;
        }

        public string Additem(string code, int amount)
        {
            return AddCommand + " " + code + " " + amount;
        }

        public string SetVariable (string code)
        {
            return SetVarCommand + " " + code;
        }

        public string AddPerk(string code)
        {
            return AddPerkCommand + " " + code;
        }

        public string SpawnNPC(string code, int amount)
        {
            return SpawnCommand + " " + code + " " + amount;
        }

        public string SetLevel(string level)
        {
            return SetLevelCommand + " " + level;
        }

        public string MapCommand(string mode)
        {
            if (mode.Equals("1"))
            {
                return MapMarkersCommand + " " + 1;
            }
            else if (mode.Equals("0"))
            {
                return MapMarkersCommand + " " + 0;
            }
            else if (mode.Equals("1,0,1"))
            {
                return MapMarkersCommand + " 1,0,1";
            }
            else
            {
                return null;
            }
        }

        public void AddAssociation(string category,string type)
        {
            if (type == "Item")
            {
                Association.Add(category, AddCommand);
                
            }
            else if (type == "NPC")
            {
                Association.Add(category, SpawnCommand);
            }
            else
            {
                Association.Add(category, type);
            }
        }

        public Dictionary<string,string> GetAssociations()
        {
            return Association;
        }
    }
}
