using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion.Factorial
{
    internal class CodeFile
    {
        public int Factorial(int num)
        {
            if (num <= 1)
            {
                return 1;
            }

            return Factorial(num - 1) * num;
        }

        public int Factorial_Iterative(int num)
        {
            var output = 1; 

            for (var i = 1; i<= num; i++)
            {
                output *= i;
            }

            return output;
        }
    }
}
