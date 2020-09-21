using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlaning
{
    public class State
    {
        public State(int _money = 0, bool _hasLoan = false)
        {
            money = _money;
            hasLoan = _hasLoan;
        }
        public bool hasLoan = false;
        public int money = 1000;
    }
}
