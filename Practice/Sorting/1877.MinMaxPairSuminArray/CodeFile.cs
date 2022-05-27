using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._1877.MinMaxPairSuminArray
{
    public class CodeFile
    {
        public int MinPairSum(int[] nums)
        {
            Array.Sort(nums);
            var max = 0;

            for (int i = 0; i < nums.Length / 2; i++)
            {
                max = Math.Max(max, nums[i] + nums[nums.Length - 1 - i]);
            }

            return max;
        }
    }
}
