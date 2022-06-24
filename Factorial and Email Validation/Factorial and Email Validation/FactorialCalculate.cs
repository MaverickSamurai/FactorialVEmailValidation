using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial_and_Access
{
    public class FactorialCalc
    {
        public int Factorial(int num)
        {
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = Factorial(num - 1) * num;
                return result;
            }
        }


    }

}
