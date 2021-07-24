using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.ConcatenationofArray
{
    class CodeFile
    {
        public int[] GetConcatenation(int[] nums)
        {
            var len = nums.Length;
            var ans = new int[len * 2];

            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[i];
                ans[i + len] = nums[i];
            }

            return ans;
        }
    }
}
