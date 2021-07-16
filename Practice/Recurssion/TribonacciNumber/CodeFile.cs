using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.TribonacciNumber
{
    class CodeFile
    {
        public int Tribonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }

            if (n == 2)
            {
                return 1;
            }

            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, 0);
            map.Add(1, 1);
            map.Add(2, 1);

            for (int i = 3; i <= n; i++)
            {

                var result = map[i - 1] + map[i - 2] + map[i - 3];
                map.Add(i, result);

            }

            return map[n];


        }
    }
}
