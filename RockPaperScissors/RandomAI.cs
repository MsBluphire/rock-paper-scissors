using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RandomAI : IPlayer
    {
        Random random = new Random();
        // to construct a new random move each time
        public int NextMove()
        {
            //<returns>0 for rock, 1 for paper, 2 for scissors</returns>
            // add a random number generator
           return random.Next(0, 3);
            // 0 - min value 3 - max value, in order to pass get a 2 you have go past the number to make sure it is included
        }

        public void SaveResult(int myMove, int otherMove)
        {
           // this method intentionally left blank because a random would not save the next move
        }
    }
}
