using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays._2535.DiffBtwElementSumDigitSum
{
    internal class CodeFile_Slow
    {
        public int DifferenceOfSum(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
                foreach (char ch in num.ToString())
                    sum -= (ch - '0');
            }
            return sum;
        }
    }
}
