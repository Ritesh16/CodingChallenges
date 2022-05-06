using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._2154.KeepMultiplyingFoundValuesby2
{
    public class CodeFile
    {
        public int FindFinalValue(int[] nums, int original)
        {
            if(nums.Length > 1)
            {
                Array.Sort(nums);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if(original == nums[i])
                {
                    original = original * 2;
                }
            }

            return original;
        }
    }
}
