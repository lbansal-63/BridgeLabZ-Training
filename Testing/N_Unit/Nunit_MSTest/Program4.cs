using System;
using System.Collections.Generic;
using System.Text;

namespace Nunit_MSTest
{
    internal class Program4
    {
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new ArithmeticException("Cannot divide by zero");

            return a / b;
        }
    }
}
