using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practice.Arrays._2206.DivideArrayInEqualPair
{
    public class CodeFile_Sorting
    {
        public bool DivideArray(int[] nums)
        {
            var result = true;
            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i = i + 2)
            {
                if (nums[i] != nums[i - 1])
                {
                    return false;
                }
            }

            return result;
        }
    }
}
