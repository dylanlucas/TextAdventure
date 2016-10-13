using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Engine
    {
        public bool repeat { get; set; }
        public World gameWorld { get; set; }

        public string commandEnter(string userInput)
        {
            string output = "";
            userInput = userInput.ToLower();
            if(repeat)
            {
                output += userInput + "\n";
            }
        }
    }
}
