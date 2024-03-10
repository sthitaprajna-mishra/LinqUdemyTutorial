using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRoll.Interfaces;
using DiceRoll.Utilities;

namespace DiceRoll
{
    public class StartGame
    {
        private int ChancesLeft = 3;
        private const int NumberOfDiceSides = 6;
        private readonly int RandomNumber;
        private readonly IRandomNumberGenerator DiceNumberGenerator;
        private readonly IPrinter ConsolePrinter;

        public StartGame() : this(new RandomNumberGenerator(), new Printer()) { }
        public StartGame(IRandomNumberGenerator randomNumberGenerator, IPrinter printer)
        {
            DiceNumberGenerator = randomNumberGenerator;
            ConsolePrinter = printer;
            RandomNumber = DiceNumberGenerator.Generate(1, NumberOfDiceSides);
        }

        public void Run()
        {
            ConsolePrinter.Start();

            while (ChancesLeft > 0)
            {
                var userInput = Console.ReadLine();
                
                if(string.IsNullOrEmpty(userInput) || !int.TryParse(userInput, out int parsedUserInput))
                {
                    ConsolePrinter.IncorrectInput();
                }
                else if(parsedUserInput != RandomNumber)
                {
                    if (ChancesLeft == 1)
                    {
                        ConsolePrinter.Lose(true);
                    }
                    else
                    {
                        ConsolePrinter.Lose(false);
                    }
                    ChancesLeft--;
                }
                else if(parsedUserInput == RandomNumber)
                {
                    ConsolePrinter.Win();
                    break;
                }
            }
        }
    }
}
