using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StubbornAI : IPlayer
    {
                
        public int NextMove()
        {
            return favoriteMove;
        }

        public void SaveResult(int myMove, int otherMove)
        {
            
        }

        // instance variable to pass through constructor
       public int favoriteMove;
        // created constructor need to pass one parameter favoriteMove
        public StubbornAI()
        {
            favoriteMove = 2;  
        }
    }

}
