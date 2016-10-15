using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH8P1
{
    class Bag
    {
        public String bagItemName { get; set; }
        public String bagItemDescription { get; set; }
        public bool bagContains { get; set; }
      
        override
        public String ToString()
        {
            String output;

            output = bagItemName + bagItemDescription + "\n";
            return output;
        }

    }
}
