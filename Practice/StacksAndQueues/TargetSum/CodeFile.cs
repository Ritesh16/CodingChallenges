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
            TargetSum(nums, target, 0, 0);
            return count;
        }


        public void TargetSum(int[] nums, int target, int sum, int index)
        {
            if (index== nums.Length)
            {
                if (target == sum)
                {
                    count++;
                }
            }
            else
            {
                Console.WriteLine($"Sum : {sum}, Index : {index}");
                TargetSum(nums, target, sum + nums[index], index + 1);
                TargetSum(nums, target, sum - nums[index], index + 1);
            }
        }
        
    }
}
