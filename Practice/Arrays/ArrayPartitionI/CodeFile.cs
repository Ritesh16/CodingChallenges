using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Arrays.ArrayPartitionI
{
    class CodeFile
    {
        public int ArrayPairSum(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums[0];
            }

            Array.Sort(nums);
            var sum = 0;
            for (int i = 0; i < nums.Length; i = i + 2)
            {
                sum += Math.Min(nums[i], nums[i + 1]);
            }

            return sum;
        }
    }
}
