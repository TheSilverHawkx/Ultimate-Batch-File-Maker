using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBatchFileMaker.Models
{
    class Category
    {
        public string name { get; set; }
        public string type { get; set; }
        public List<ItemObject> Resources { get; set; }
    }
}
