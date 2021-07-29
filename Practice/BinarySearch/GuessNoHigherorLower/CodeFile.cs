using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearch.GuessNoHigherorLower
{
    class CodeFile : GuessGame
    {
        public int GuessNumber(int n)
        {
            int i = 1, j = n;
            while (i <= j)
            {
                int mid = i + (j - i) / 2;
                if (guess(mid) > 0)
                    i = mid + 1;
                else if (guess(mid) < 0)
                    j = mid - 1;
                else
                    return mid;
            }
            return -1;
        }
    }

    internal class GuessGame
    {
        internal int guess(int mid)
        {
            return 0;
        }
    }
}
