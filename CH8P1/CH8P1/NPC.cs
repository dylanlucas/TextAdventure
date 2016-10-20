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
        private string riddleAns;
        private int riddleNum;
        private string output;

        Random rand = new Random();

        public NPC()
        {
            name = "Jaylon";
        }

        public string riddleAnswer {get; set;}

        /**
         * 
         */ 
        public string sayRiddle()
        {
            if (rand.Next(3) + 1 == 1)
            {
                riddle = "You will always find me in the past. I can be created in the present,"
                        + "But the future can never taint me. What am I?";
                riddleNum = 1;
            }
            else if (rand.Next(3) + 1 == 2)
            {
                riddle = "What do you get when you cross a snowman with a vampire?";
                riddleNum = 2;
            }
            else if (rand.Next(3) + 1 == 3)
            {
                riddle = "What belongs to you but others use it more than you do?";
                riddleNum = 3;
            }

            return riddle;
        }

        public void checkAnswer(string s)
        {
            if(riddleNum == 1)
            {
                if(s.ToLower().Equals("history"))
                {
                    output = "Correct";
                }
                else if(!s.ToLower().Equals("history"))
                {
                    output = "That is not the correct answer";
                }
            }
        }

        
        //override
        //public String ToString()
        //{
        //    String output;
       
        //    //return output;
        //}
       
    }
}
