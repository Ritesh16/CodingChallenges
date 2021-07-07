using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.FibonacciNumber
{
    class CodeFile
    {
        public int Fib(int N)
        {
            var first = 0;
            var last = 1;
            var result = 0;
            if (N <= 0) return first;
            if (N < 2) return last;

            for (int i = 2; i <= N; i++)
            {
                result = first + last;
                first = last;
                last = result;
            }

            return result;
        }

    }
}
