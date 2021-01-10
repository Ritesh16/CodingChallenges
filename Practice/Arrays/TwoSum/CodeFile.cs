using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.TwoSum
{
    public class CodeFile
    {
        public int[] TwoSum(int[] nums, int target)
        {
            // Brute Force
            var output = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        output[0] = i;
                        output[1] = j;
                        return output;
                    }
                        
                }
            }

            return output;
        }

        public int[] TwoSumBetter(int[] nums, int target)
        {
            var output = new int[2];
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(dic.ContainsKey(nums[i]))
                {
                    var item = dic[nums[i]];
                    output[0] = item;
                    output[1] = i;
                    return output;
                }
                else
                {
                    var num = target - nums[i];
                    dic[num] = i;
                }
            }

            return output;
        }
    }
}
