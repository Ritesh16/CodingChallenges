using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.MaxConsecutiveOnes
{
    public class CodeFile
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var count = 0;
            var maxConsecutiveNumber = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count++;
                if (nums[i] == 0)
                {
                    count = 0;
                }

                if (count > maxConsecutiveNumber)
                    maxConsecutiveNumber = count;
            }

            return maxConsecutiveNumber;
        }
    }
}
