using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateBatchFileMaker.Models;

namespace UltimateBatchFileMaker
{
    class JsonParser
    {
        private DefinitionsObject Defintions;

        // 
        // Constructor - Gets .json file path from getFilePath and Parse it into a list of strongly-typed classes 'Contact' and 'Adviser".
        //
        public JsonParser()
        {

        }

        public JsonParser(string definition_file_path)
        {
            Defintions = (DefinitionsObject)DeserializeFromStream(definition_file_path,"definition");

        }

        public string GetGameName()
        {
            return Defintions.Game;
        }

        public KeyValuePair<string,DataTable> LoadResourceFile(string file_path)
        {
            ResourceObject resourceObject = (ResourceObject)DeserializeFromStream(file_path,"resource");

            if (Defintions.Game == resourceObject.Game)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Category");
                dt.Columns.Add("Name");
                dt.Columns.Add("Code");
                dt.Columns.Add("Amount", Type.GetType("System.Int32"));

                if (resourceObject.Resources != null)
                {
                    foreach (var row in resourceObject.Resources)
                    {
                        DataRow dr = dt.NewRow();
                        dr["Category"] = resourceObject.Name;
                        dr["Name"] = row.name;
                        dr["Code"] = row.code;
                        dr["Amount"] = 0;
                        dt.Rows.Add(dr);
                    }
                }
                else if (resourceObject.Categories != null){
                    foreach (var category in resourceObject.Categories)
                    {
                        foreach (var row in category.Resources)
                        {
                            DataRow dr = dt.NewRow();
                            dr["Category"] = category.name;
                            dr["Name"] = row.name;
                            dr["Code"] = row.code;
                            dr["Amount"] = 0;
                            dt.Rows.Add(dr);
                        }
                    }
                }
                return new KeyValuePair<string,DataTable>(resourceObject.Name, dt);
            }
            else
            {
                MessageBox.Show("Resource file belongs to " + Defintions.Game +", skipping");
                return new KeyValuePair<string, DataTable>();
            }

        }

        public bool AssociateCategory(string category_name)
        {
            return Defintions.AssociateCategory(category_name);
        }

        public string UpdateMapCommand(string mode)
        {
            return Defintions.UpdateMapCommand(mode);
        }

        public void CreateResourceFile(string game_name, string category_name, List<string[]> resources, string file_path)
        {
            List<ItemObject> item_list = new List<ItemObject>();

            foreach (var resource in resources)
            {
                ItemObject item = new ItemObject { name = resource[0], code = resource[1] };

                item_list.Add(item);
            }

            ResourceObject resourceObject = new ResourceObject
            {
                Game = game_name,
                Name = category_name,
                Resources = item_list
            };

            SerializeFromStream(resourceObject, file_path);
        }

        public void CreateDefinitionFile(string game_name, DataTable definitions_table, string path)
        {
            List<DefinitionObject> definition_list = new List<DefinitionObject>();
            foreach (DataRow row in definitions_table.Rows)
            {
                DefinitionObject def = new DefinitionObject
                {
                    name = row[0].ToString().Replace(" ", string.Empty),
                    command = row[1].ToString()
                };
                definition_list.Add(def);
            }

            DefinitionsObject definitionsObject = new DefinitionsObject
            {
                Game = game_name,
                Definitions = definition_list,
                KnownCategories = new List<Category>()
            };

            SerializeFromStream(definitionsObject, path);
        }

        public string GetCommand(string name)
        {
            return Defintions.GetCommand(name);
        }

        public Dictionary<string, string> GetAssociations()
        {
            return Defintions.GetAssociations();
        }


        //
        // SUPPORT METHODS
        //
        //
        // Support Method- Deserialize JSON format from a FileStream object.
        // Returns an object (either DefinitionsObject or ResourceObject).
        //
        private object DeserializeFromStream(string file_path, string t)
        {
            var serializer = new JsonSerializer();

            FileStream stream = new FileStream(file_path, FileMode.Open);

            using (var sr = new StreamReader(stream))
            using (JsonTextReader jsonTextReader = new JsonTextReader(sr))
            {
                if (t == "definition")
                {
                    return serializer.Deserialize<DefinitionsObject>(jsonTextReader);
                }
                else if (t == "resource")
                {
                    return serializer.Deserialize<ResourceObject>(jsonTextReader);
                }
                else
                {
                    return null;
                }
                
            }
        }

        //
        // Support Method- Serialize JSON format to a FileStream object.
        //
        private void SerializeFromStream(object obj, string file_path)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter(file_path))
            using (JsonTextWriter jtw = new JsonTextWriter(sw))
            {
                serializer.Serialize(jtw, obj);
            }
        }
    }
}
