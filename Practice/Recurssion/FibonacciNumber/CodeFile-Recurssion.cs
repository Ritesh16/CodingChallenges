using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.FibonacciNumber
{
    class CodeFileRecusrssion
    {
        public int Fib(int N)
        {
            return CalculateFib(N);
        }

        private int CalculateFib(int n)
        {
            if (n == 1) return 1;

            if (n <= 0) return 0;

            return CalculateFib(n - 1) + CalculateFib(n - 2);
        }
    }
}
