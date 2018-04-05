using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimateBatchFileMaker.Models
{
    class DefinitionsObject
    {
        public static string[] functionalityList = { "Add Item", "Set Value", "Add Perk", "Spawn NPC", "Set Level", "Map Command" };

        public string Game { get; set; }
        public List<DefinitionObject> Definitions { get; set; }
        public List<Category> KnownCategories { get; set; }
        private Dictionary<string, string> Association = new Dictionary<string, string>();

        public bool AssociateCategory(string category_name)
        {
            if (KnownCategories.Exists(x => x.name == category_name))
            {
                var known_category = KnownCategories.Where(x => x.name == category_name).First();
                string command_name = Definitions.Where(x => x.name.Contains(known_category.type)).First().name;
                Association.Add(known_category.name, command_name);
            }
            else
            {
                using (AssociationPopup frm = new AssociationPopup())
                {
                    frm.CategoryName = category_name;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        string val = frm.ReturnValue;

                        if (KnownCategories.Exists(x => x.type == val))
                        {
                            string command_name = Definitions.Where(x => x.name.Contains(val)).First().name;
                            Association.Add(val, command_name);
                        }
                        else
                        {
                            Association.Add(category_name, val);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No association specified, skipping");
                        return false;
                    }
                }

            }
            return true;
        }

        public string GetCommand(string name)
        {
            return Definitions.Where(x => x.name.Contains(name)).First().command;
        }

        public Dictionary<string, string> GetAssociations()
        {
            return Association;
        }

        public string UpdateMapCommand(string mode)
        {
            string mapCommand = Definitions.Where(x => x.name.Contains("map")).First().command;

            if (mode.Equals("1"))
            {
                return mapCommand + " " + 1;
            }
            else if (mode.Equals("0"))
            {
                return mapCommand + " " + 0;
            }
            else if (mode.Equals("1,0,1"))
            {
                return mapCommand + " 1,0,1";
            }
            else
            {
                return null;
            }
        }
        //
        // SUPPORT METHODS
        //

    }
}
