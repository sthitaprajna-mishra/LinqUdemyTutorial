using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRoll.Interfaces;

namespace DiceRoll.Utilities
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        public int Generate(int Start, int End)
        {
            Random random = new Random();
            return random.Next(Start, End + 1);
        }
    }
}
