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
        public int Score { get; set; } = 0;

        public bool GameWon { get; set; } = false;
        public bool GameLoss { get; set; } = false;




        public Player()
        {

            while (true)
            {

                Console.WriteLine("Please enter your name" + System.Environment.NewLine);
                PlayerName = Console.ReadLine();

                if (string.IsNullOrEmpty(PlayerName))
                    Console.WriteLine("Player Name can't be left blank" + System.Environment.NewLine);
            else break;
            }
        }
        
    }
}
