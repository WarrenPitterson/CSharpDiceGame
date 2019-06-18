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

            Console.WriteLine($"Hello {player.PlayerName}");

            DiceRoll random = new DiceRoll();
            //Console.WriteLine($"You rolled a {random.RandomDiceRoll()}");

            while (gameStatus)
            {
                int CurrentRoll = random.RandomDiceRoll();

                player.Score = player.Score + CurrentRoll;


                if (CurrentRoll == 1)
                {
                    Console.WriteLine($"You Rolled a {random.RandomDiceRoll()}");
                    Console.WriteLine($"Final Score is {player.Score}");
                    Console.WriteLine("game over!");
                    gameStatus = false;

                }
                else if (player.Score > 21)
                {
                    Console.WriteLine($"You Rolled a {random.RandomDiceRoll()}");
                    Console.WriteLine($"Final Score is {player.Score}");
                    Console.WriteLine($"Congratulations You've won with a score of {player.Score}");
                    gameStatus = false;
                }
                else
                {
                    Console.WriteLine($"You Rolled a {random.RandomDiceRoll()}");
                    Console.WriteLine($"Current Score is {player.Score}");
                }

                    Console.ReadLine();
            }

        }

        private void ResetGame()
        {
            player.Score = 0;
            gameStatus = true;
            RunGame();
        }
        
    }

        
}


