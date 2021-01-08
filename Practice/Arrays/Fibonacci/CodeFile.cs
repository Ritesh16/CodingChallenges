using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.Fibonacci
{
    public class CodeFile
    {
        // Recurssion
        public int Fib(int N)
        {
            return CalculateFib1(N);
        }

        private int CalculateFib(int n)
        {
            if (n == 1) return 1;

            if (n <= 0) return 0;

            return CalculateFib(n - 1) + CalculateFib(n-2);
        }

        private int CalculateFib1(int n)
        {
            var first = 0;
            var last = 1;
            var result = 0;
            if (n <= 0) return first;

            for (int i = 1; i < n; i++)
            {
                result = first + last;
                first = last;
                last = result;
            }

            return result;
        }

    }
}
