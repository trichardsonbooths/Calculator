using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        private int NumberOne { get; set; }
        private int NumberTwo { get; set; }

        public Calculator(int _numberOne, int _numberTwo)
        {
            NumberOne = _numberOne;
            NumberTwo = _numberTwo;
        }

        public int Addition()
        {
            return NumberOne + NumberTwo;
        }

        public int SubTraction()
        {
            return NumberOne - NumberTwo;
        }
    }
}
