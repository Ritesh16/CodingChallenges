using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.MaxConsecutiveOnesII
{
    public class CodeFile
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var numZero = 0;
            var left = 0;
            var right = 0;
            var maxSequence = 0;

            while (right < nums.Length)
            {
                if(nums[right] == 0)
                {
                    numZero++;
                }

                while(numZero == 2)
                {
                    if(nums[left] == 0)
                    {
                        numZero--;
                    }

                    left++;
                }

                maxSequence = Math.Max(maxSequence, right - left + 1);
                right++;
            }

            return maxSequence;
        }
    }
}
