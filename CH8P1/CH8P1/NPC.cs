using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH8P1
{
    class NPC
    {
        private string name = "";
        private string riddle;
        private string output;

        public NPC()
        {
            name = "Jaylon";
        }

        public string sayRiddle1()
        {
            riddle = "You will always find me in the past. I can be created in the present,"
                    + "But the future can never taint me. What am I?\n";
            return riddle;
        }

        public string sayRiddle2()
        {
            riddle = "What do you get when you cross a snowman with a vampire?\n";
            return riddle;
        }

        public string sayRiddle3()
        {
            riddle = "What belongs to you but others use it more than you do?\n";
            return riddle;
        }

        public string sayOutput
        {
            get
            {
                return output;
            }
        }

    }
}