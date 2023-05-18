using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Arrays._2574.LeftandRightSumDifferences
{
    public class CodeFile
    {
        public int[] LeftRigthDifference(int[] nums)
        {
            var rightSum = nums.Sum(x => x);
            var leftSum = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                var current = nums[i];
                rightSum = rightSum - current;
                nums[i] = Math.Abs(rightSum - leftSum);
                leftSum = leftSum + current;

            }

            return nums;
        }
    }
}
