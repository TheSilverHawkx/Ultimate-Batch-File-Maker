using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBatchFileMaker.Models
{
    class ResourceObject
    {
        public string Game { get; set; }
        public string Name { get; set; }
        public List<ItemObject> Resources { get; set; }
        public List<Category> Categories { get; set; }
    }
}
