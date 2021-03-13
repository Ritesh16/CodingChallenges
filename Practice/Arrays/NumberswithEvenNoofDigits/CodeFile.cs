using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.NumberswithEvenNoofDigits
{
    public class CodeFile
    {
        public int FindNumbers(int[] nums)
        {
            var result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var digitsCount = CalculateDigits(nums[i]);
                if (digitsCount % 2 == 0)
                {
                    result++;
                }
            }

            return result;
        }

        public int CalculateDigits(int num)
        {
            var count = 1;
            var divident = num / 10;
            while (divident > 0)
            {
                count++;
                divident = divident / 10;
            }

            return count;
        }
    }
}
