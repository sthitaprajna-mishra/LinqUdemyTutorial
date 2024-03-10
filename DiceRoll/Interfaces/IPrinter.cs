using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll.Interfaces
{
    public interface IPrinter
    {
        public void Start();
        public void Win();
        public void Lose(bool areAllChancesLost);
        public void IncorrectInput();
    }
}
