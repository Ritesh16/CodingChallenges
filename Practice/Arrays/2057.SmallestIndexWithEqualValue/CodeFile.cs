using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays._2057.SmallestIndexWithEqualValue
{
    public class CodeFile
    {
        public int SmallestEqual(int[] nums)
        {
            var result = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 10 == nums[i])
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
    }
}
