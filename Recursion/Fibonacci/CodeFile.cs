using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion.Fibonacci
{
    public class CodeFile
    {
        public int Fibonacci(int n)
        {
            if (n <= 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public int Fibonacci_Iterative(int n)
        {
            var output = 0;
            var first = 0;
            var second = 1;

            if (n == 0)
            {
                return first;
            }

            if (n == 1)
            {
                return second;
            }

            for (var i = 2; i <= n; i++)
            {
                output = first + second;
                first = second;
                second = output;
            }

            return output;
        }
    }
}
