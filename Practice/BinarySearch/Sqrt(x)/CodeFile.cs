using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearch.Sqrt_x_
{
    class CodeFile
    {
        public int MySqrt_Inbuilt(int x)
        {
            return (int)Math.Floor(Math.Sqrt(x));
        }

        public int MySqrt(int x)
        {
            if (x < 2)
                return x;

            int left = 1, right = x / 2;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (mid == x / mid)
                    return mid;
                else if (mid < x / mid)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return right;
        }
    }
}
