using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    class DiceRoll
    {
        public int Random()
        {
            Random randomRoll = new Random();
            return randomRoll.Next(1, 6);
        }
    }
}
