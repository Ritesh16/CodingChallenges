using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays._1913.MaxProductDiffBetween2Pairs
{
    public class CodeFile
    {
        public int MaxProductDifference(int[] nums)
        {
            Array.Sort(nums);
            var result = 0;

            var pair2Multiply = nums[0] * nums[1];
            var pair1Multiply = nums[nums.Length - 1] * nums[nums.Length - 2];

            result = pair1Multiply - pair2Multiply;
            return result;
        }
    }
}
