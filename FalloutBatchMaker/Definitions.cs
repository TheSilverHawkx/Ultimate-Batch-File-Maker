using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBatchFileMaker
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



        public Dictionary<string,string> GetAssociations()
        {
            return Association;
        }
    }
}
