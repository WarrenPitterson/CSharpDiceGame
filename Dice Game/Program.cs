using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Warren's Dice Game!");
            Console.WriteLine("Please enter your name");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Hello {playerName}");
            

            DiceRoll random = new DiceRoll();
            Console.WriteLine($"Random dice roll is {random.Random()}");
            Console.ReadKey();

        }
    }
}
