using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._2154.KeepMultiplyingFoundValuesby2
{
    public class CodeFile_Fast
    {
        public int FindFinalValue(int[] nums, int original)
        {
            int i = 0;
            int j = nums.Length - 1;

            while (i <= j)
            {
                if (nums[i] == original || nums[j] == original)
                {
                    original *= 2;
                    i = -1;
                    j = nums.Length;
                }
                i++;
                j--;
            }
            return original;
        }
    }
}
