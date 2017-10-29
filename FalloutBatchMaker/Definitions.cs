using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalloutBatchMaker
{
    class Definitions
    {
        private string addCommand { get; set; }
        private string setValCommand { get; set; }
        private string addPerkCommand { get; set; }
        private string spawnCommand { get; set; }
        private string setLevelCommand { get; set; }
        private string mapMarkersCommand { get; set; }


        public Definitions(string add, string setV, string addP, string spawn, string setlvl, string mapcomm)
        {
            addCommand = add;
            setValCommand = setV;
            addPerkCommand = addP;
            spawnCommand = spawn;
            setLevelCommand = setlvl;
            mapMarkersCommand = mapcomm;
        }

        public string additem(string code, int amount)
        {
            return addCommand + " " + code + " " + amount;
        }

        public string setValue (string code, int amount)
        {
            return setValCommand + " " + code + " " + amount;
        }

        public string addPerk(string code)
        {
            return addPerkCommand + " " + code;
        }

        public string spawnNPC(string code, int amount)
        {
            return spawnCommand + " " + code + " " + amount;
        }

        public string setLevel(string code, int amount)
        {
            return setLevelCommand + " " + code + " " + amount;
        }

        public string mapCommand(string mode)
        {
            if (mode.Equals("1"))
            {
                return mapMarkersCommand + " " + 1;
            }
            else if (mode.Equals("0"))
            {
                return mapMarkersCommand + " " + 0;
            }
            else if (mode.Equals("1,0,1"))
            {
                return mapMarkersCommand + " 1,0,1";
            }
            else
            {
                return null;
            }
        }

    }
}
