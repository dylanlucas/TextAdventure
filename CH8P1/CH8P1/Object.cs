using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH8P1
{
    class Object
    {
        public int itemID { get; set; }
        public string itemName { get; set; }
        public string itemDescription { get; set; }
        public int itemLocation { get; set; }

        override
        public String ToString()
        {
            String output;

            output = itemName + "\n" + itemDescription + "\n";
            return output;
        }
    }
}
