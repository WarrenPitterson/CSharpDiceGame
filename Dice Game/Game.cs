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
        private readonly Score score = new Score();
        DiceRoll random = new DiceRoll();
        private bool gameStatus = true;
        private string userInstruction;


        public Game()
        {
            Console.WriteLine($"Hello {player.PlayerName}");

            RunGame();
        }

        public void RunGame()
        {

            while (gameStatus)
            {
                int CurrentRoll = random.RandomDiceRoll();

                player.Score = player.Score + CurrentRoll;


                if (CurrentRoll == 1)
                {
                    Gameover();
                }
                else if (player.Score > 21)
                {
                    Gameover();
                }
                else
                {
                    Console.WriteLine($"You Rolled a {random.RandomDiceRoll()}");
                    Console.WriteLine($"Current Score is {player.Score}");

                    Console.ReadLine();
                }
            }
        }

        private void UserInput(string userInstruction)
        {
            if (userInstruction == "r")
            {
                ResetGame();
            }
            else if (userInstruction == "q")
            {
                Environment.Exit(0);
            }
        }

        private void ResetGame()
        {
            player.GameWon = false;
            player.GameLoss = false;
            player.Score = 0;
            gameStatus = true;
            RunGame();
        }

        private void Gameover()
        {
            if (player.GameWon)
            {
                Console.WriteLine($"You Rolled a {random.RandomDiceRoll()}");
                Console.WriteLine($"Final Score for {player.PlayerName} is {player.Score}");
            }

            else

            {
                Console.WriteLine($"You Rolled a {random.RandomDiceRoll()}");
                Console.WriteLine($"Final Score for {player.PlayerName} is {player.Score}");
                Console.WriteLine("Game over!");
            }
            gameStatus = false;

            Console.WriteLine("Please press r to Restart or q to Quit");

            userInstruction = Console.ReadLine().ToLower().Trim();


            UserInput(userInstruction);

        }

    }

}

        

