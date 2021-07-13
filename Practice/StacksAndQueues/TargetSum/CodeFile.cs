using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StacksAndQueues.TargetSum
{
    class CodeFile
    {
        int count = 0;
        public int FindTargetSumWays(int[] nums, int target)
        {
            TargetSums(nums, target, 0, 0);
            return count;
        }

        public void TargetSums(int[] nums, int target, int index, int sum)
        {
            if (index == nums.Length)
            {
                if (sum == target)
                {
                    count++;
                }
            }
            else
            {
                TargetSums(nums, target, index + 1, sum + nums[index]);
                TargetSums(nums, target, index + 1, sum - nums[index]);
            }
        }
    }
}
