using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.HashTables.CountNumberofPairs
{
    internal class CodeFile_Fast
    {
        public int CountKDifference(int[] nums, int k)
        {
            int m = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k)
                        m++;
                }
            }
            return m;
        }
    }
}
