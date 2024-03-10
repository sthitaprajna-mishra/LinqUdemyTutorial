using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRoll.Interfaces;

namespace DiceRoll.Utilities
{
    public class Printer : IPrinter
    {
        public void Start()
        {
            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
        }

        public void IncorrectInput()
        {
            Console.WriteLine("Incorrect input");
            Retry();
        }

        public void Lose(bool areAllChancesLost)
        {
            Console.WriteLine("Wrong number");
            if (areAllChancesLost)
            {
                Console.WriteLine("You lose");
            }
            else
            {
                Retry();
            }
        }

        public void Win()
        {
            Console.WriteLine("You win");
        }

        public static void Retry()
        {
            Console.WriteLine("Enter number: ");
        }
    }
}
