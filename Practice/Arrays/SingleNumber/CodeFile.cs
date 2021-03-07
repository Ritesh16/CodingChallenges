using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.SingleNumber
{
    public class CodeFile
    {
        public int SingleNumber(int[] nums)
        {
            var a = 10 ^ 5;
            a = a ^ 5;
            var result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }

            return result;
        }
    }
}
