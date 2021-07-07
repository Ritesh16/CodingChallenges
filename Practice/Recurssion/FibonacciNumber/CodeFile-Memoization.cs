using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.FibonacciNumber
{
    class CodeFile_Memoization
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        public int Fib(int n)
        {
            if (map.ContainsKey(n))
            {
                return map[n];
            }

            if (n < 2)
            {
                return n;
            }

            var result = Fib(n - 1) + Fib(n - 2);
            map.Add(n, result);
            return result;
        }
    }
}
