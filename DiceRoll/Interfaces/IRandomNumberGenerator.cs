using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll.Interfaces
{
    public interface IRandomNumberGenerator
    {
        public int Generate(int Start, int End);
    }
}
