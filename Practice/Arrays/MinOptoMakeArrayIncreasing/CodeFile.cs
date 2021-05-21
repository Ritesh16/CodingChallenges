using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.MinOptoMakeArrayIncreasing
{
    public class CodeFile
    {
        public int MinOperations(int[] nums)
        {
            int operations = 0;
            if (nums.Length < 1)
            {
                return operations;
            }

            int i = 1;
            while (i < nums.Length)
            {
                var prev = i - 1;
                if (nums[prev] < nums[i])
                {
                    i++;
                }
                else
                {
                    var difference = nums[prev] - nums[i] + 1;
                    nums[i] = nums[i] + difference;
                    operations += difference;
                }
            }


            return operations;
        }
    }
}
