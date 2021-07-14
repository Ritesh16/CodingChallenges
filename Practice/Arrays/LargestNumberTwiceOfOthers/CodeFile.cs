using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.LargestNumberTwiceOfOthers
{
    class CodeFile
    {
        public int DominantIndex(int[] nums)
        {
            var largest = 0;
            var index = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (largest < nums[i])
                {
                    largest = nums[i];
                    index = i;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != largest && nums[i] * 2 > largest)
                {
                    index = -1;
                    break;
                }
            }

            return index;
        }
    }
}
