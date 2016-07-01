using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StubbornAI : IPlayer
    {
        //created instance variable to be able to pass through constructor
      
        
    
        public int NextMove()
        {
            return favoriteMove;
        }

        public void SaveResult(int myMove, int otherMove)
        {
            
        }

        // created constructor need to pass one parameter favoriteMove
        public int favoriteMove;
       public StubbornAI()
        {
            favoriteMove = 2;  
        }
    }

}
