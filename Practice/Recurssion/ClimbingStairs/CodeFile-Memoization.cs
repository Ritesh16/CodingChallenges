using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.ClimbingStairs
{
    class CodeFileMemoization1
    {
        public int ClimbStairs(int n)
        {
            int result = n;
            result = CountStairs(0, n);

            return result;
        }

        Dictionary<int, int> map = new Dictionary<int, int>();


        private int CountStairs(int i, int n)
        {
            if (map.ContainsKey(i))
            {
                return map[i];
            }

            if (i > n)
            {
                return 0;
            }

            if (i == n)
            {
                return 1;
            }

            var r = CountStairs(i + 1, n) + CountStairs(i + 2, n);
            map.Add(i, r);
            return r;
        }
    }
}
