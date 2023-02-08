using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays._2535.DiffBtwElementSumDigitSum
{
    internal class CodeFile
    {
        public int DifferenceOfSum(int[] nums)
        {
            int result = 0;
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 10)
                {
                    sum1 += nums[i];
                    var k = nums[i];
                    while (k > 0)
                    {
                        sum2 += (k % 10);
                        k /= 10;
                    }
                }
            }

            result = Math.Abs(sum1 - sum2);
            return result;
        }
    }
}
