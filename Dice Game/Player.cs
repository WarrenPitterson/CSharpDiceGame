using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }

        public Player()
        {

            while (true)
            {

                Console.WriteLine("Please enter your name");
                PlayerName = Console.ReadLine();

                if (string.IsNullOrEmpty(PlayerName))
                    Console.WriteLine("Player Name can't be left blank");
            else break;
            }
        }
        
    }
}
