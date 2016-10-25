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
        private int riddleNum;
        private string output;
        private bool checkIfUsed = false;

        public NPC()
        {
            name = "Jaylon";
        }

        public string riddleAnswer { get; set; }
        /**
         * 
         */
        public string sayRiddle1()
        {
            riddle = "You will always find me in the past. I can be created in the present,"
                    + "But the future can never taint me. What am I?";
            riddleNum = 1;
            return riddle;
        }

        public string sayRiddle2()
        {
            riddle = "What do you get when you cross a snowman with a vampire?";
            riddleNum = 2;
            return riddle;
        }

        public string sayRiddle3()
        {
            riddle = "What belongs to you but others use it more than you do?";
            riddleNum = 3;
            return riddle;
        }

        public void checkAnswer(string s)
        {
            if (riddleNum == 1)
            {
                if (s.ToLower().Equals("history"))
                {
                    output = "Correct";
                }
                else if (!s.ToLower().Equals("history"))
                {
                    output = "That is not the correct answer";
                }
            }
            if (riddleNum == 2)
            {
                if (s.ToLower().Equals("frostbite"))
                {
                    output = "Correct";
                }
                else if (!s.ToLower().Equals("frostbite"))
                {
                    output = "That is not the correct answer";
                }
            }
            if (riddleNum == 3)
            {
                if (s.ToLower().Equals("name"))
                {
                    output = "Correct";
                }
                else if (!s.ToLower().Equals("name"))
                {
                    output = "That is notthe correct answer";
                }
            }
        }
    }
}