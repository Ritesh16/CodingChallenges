using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.MinSizeSubarraySum
{
    class CodeFile_Fastest
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int windowStart = 0;
            int smallestArrayLength = int.MaxValue;
            int currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];

                while (currentSum >= target)
                {
                    smallestArrayLength = Math.Min(smallestArrayLength, i - windowStart + 1);
                    currentSum -= nums[windowStart];
                    windowStart++;

                }
            }

            return smallestArrayLength == int.MaxValue ? 0 : smallestArrayLength;
        }
    }
}
