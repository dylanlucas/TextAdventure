using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH8P1
{
    class Item
    {
        public String itemName { get; set; }
        public String itemDescription { get; set; }

        public Item()
        {
            name = this.itemName;
            description = this.itemDescription;
        }

        public string name { get; set; }
        public string description { get; set; }

        override
        public String ToString()
        {
            String output;

            output = itemName + "\n" + itemDescription;
            return output;
        }
    }
}
