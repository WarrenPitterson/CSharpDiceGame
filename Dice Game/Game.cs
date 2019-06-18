using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
   
    public class Game
    {

        Player player = new Player();
        private Score score = new Score();
        private bool gameStatus = true;


        public Game()
        {
            Console.WriteLine("Welcome to Warren's Dice Game!");

            RunGame();            
        }

        public void RunGame()
        {
            //Add methods to run game

            
            Console.WriteLine($"Hello {player.PlayerName}");

            DiceRoll random = new DiceRoll();
            Console.WriteLine($"Random dice roll is {random.RandomDiceRoll()}");
            Console.ReadKey();

            while (gameStatus)
            {
                int Currentscore = random.RandomDiceRoll();
            }
        }
    }
}
