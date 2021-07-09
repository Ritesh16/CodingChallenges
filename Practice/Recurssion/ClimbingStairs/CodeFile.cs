using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.ClimbingStairs
{
    class CodeFileMemoization2
    {
        public int ClimbStairs(int n)
        {
            int result = n;
            int[] arr = new int[n + 1];
            result = CountStairs(0, n, arr);

            return result;
        }

        private int CountStairs(int i, int n, int[] array)
        {
            if (i > n)
            {
                return 0;
            }

            if (i == n)
            {
                return 1;
            }

            if (array[i] > 0)
            {
                return array[i];
            }

            var r = CountStairs(i + 1, n, array) + CountStairs(i + 2, n, array);
            array[i] = r;
            return r;
        }
    }
}
