using System;
using System.Collections.Generic;
using System.Text;

namespace P228
{
    internal sealed class Multiplication : Calculation
    {
        internal override int Operate(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
