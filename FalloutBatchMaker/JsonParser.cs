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
        /// <summary>
        /// The defintions
        /// </summary>
        private DefinitionsObject Defintions;

        // 
        // Constructor - Gets .json file path from getFilePath and Parse it into a list of strongly-typed classes 'Contact' and 'Adviser".
        //
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonParser"/> class.
        /// </summary>
        public JsonParser()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonParser"/> class.
        /// </summary>
        /// <param name="definition_file_path">The definition file path.</param>
        public JsonParser(string definition_file_path)
        {
            Defintions = (DefinitionsObject)DeserializeFromStream(definition_file_path,"definition");

        }

        /// <summary>
        /// Gets the name of the game specified in <see cref="Defintions"/>.
        /// </summary>
        /// <returns>The Game's name</returns>
        public string GetGameName()
        {
            return Defintions.Game;
        }

        /// <summary>
        /// Loads a resource file.
        /// </summary>
        /// <param name="file_path">Resource file path.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Associates a category to a command.
        /// </summary>
        /// <param name="category_name">Name of the category to associate.</param>
        /// <returns>Status from association. If succeeds - returns <c>true</c>.</returns>
        public bool AssociateCategory(string category_name)
        {
            return Defintions.AssociateCategory(category_name);
        }

        /// <summary>
        /// Updates the map command.
        /// </summary>
        /// <param name="mode">String representation of the mode. Can be 1, 0 or 1,0,1</param>
        /// <returns>Formated representaion of the mode.</returns>
        public string UpdateMapCommand(string mode)
        {
            return Defintions.UpdateMapCommand(mode);
        }

        /// <summary>
        /// Creates the resource file.
        /// </summary>
        /// <param name="game_name">Name of the game.</param>
        /// <param name="category_name">Name of the category.</param>
        /// <param name="resources">List of resources.</param>
        /// <param name="file_path">Save file path.</param>
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

            SerializeToFile(resourceObject, file_path);
        }

        /// <summary>
        /// Creates the definition file.
        /// </summary>
        /// <param name="game_name">Name of the game.</param>
        /// <param name="definitions_table">Datatable with definitions.</param>
        /// <param name="file_path">Save file path.</param>
        public void CreateDefinitionFile(string game_name, DataTable definitions_table, string file_path)
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

            SerializeToFile(definitionsObject, file_path);
        }

        /// <summary>
        /// Gets the command by name.
        /// </summary>
        /// <param name="name">Name of the command.</param>
        /// <returns>String representaion of the command.</returns>
        public string GetCommand(string name)
        {
            return Defintions.GetCommand(name);
        }

        /// <summary>
        /// Gets all associations.
        /// </summary>
        /// <returns>Dictionary object containing 'category : command' values</returns>
        public Dictionary<string, string> GetAssociations()
        {
            return Defintions.GetAssociations();
        }


        //
        // SUPPORT METHODS
        //

        /// <summary>
        /// Deserialize JSON format from a FileStream object.
        /// </summary>
        /// <param name="file_path">The file path.</param>
        /// <param name="type">type of deserialization. Either 'definition' or 'resource'.</param>
        /// <returns>Returns an object (either <see cref="DefinitionsObject"/> or <see cref="ResourceObject"/>).</returns>
        private object DeserializeFromStream(string file_path, string type)
        {
            var serializer = new JsonSerializer();

            FileStream stream = new FileStream(file_path, FileMode.Open);

            using (var sr = new StreamReader(stream))
            using (JsonTextReader jsonTextReader = new JsonTextReader(sr))
            {
                if (type == "definition")
                {
                    return serializer.Deserialize<DefinitionsObject>(jsonTextReader);
                }
                else if (type == "resource")
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
        /// <summary>
        /// Serializes an Object (such as <see cref="DefinitionsObject" />) to a file.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <param name="file_path">Save file path.</param>
        private void SerializeToFile(object obj, string file_path)
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
