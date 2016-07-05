using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ShortAttentionSpanAI :  IPlayer
    {
        int playerMove = 0;

        public int NextMove()
        {
            return playerMove;
            //switch statement or if/else statement would work here
           
        }

        public void SaveResult(int myMove, int otherMove)
        {
            playerMove = otherMove;


        }
    }
}
