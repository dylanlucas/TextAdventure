using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH8P1
{
    class Score
    {
        public int currentScore = 0;       //current score
        public int scoreCounter = 0;       //whenever new score is obtained
        public bool isActionCompleted = false;

        public int playerScore()
        {
            if (isActionCompleted == true)
            {
                return currentScore;
            }
            else
            {
                currentScore = currentScore += scoreCounter;
                return currentScore;
            }
        }

        override
            public String ToString()
        {
            String output;

            output = "Your score is " + currentScore;

            return output;
        }
    }
}
