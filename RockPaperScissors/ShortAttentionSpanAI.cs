using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ShortAttentionSpanAI : IPlayer
    {
        int previousMove = 0;

        public int NextMove()
        {
            return previousMove;
        }

        public void SaveResult(int myMove, int otherMove)
        {
           previousMove = otherMove; 
        }
    }
}
