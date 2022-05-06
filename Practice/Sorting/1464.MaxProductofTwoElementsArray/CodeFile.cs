using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._1464.MaxProductofTwoElementsArray
{
    public class CodeFile
    {
        public int MaxProduct(int[] nums)
        {
            var result = 0;
            if (nums.Length == 2)
            {
                result = (nums[0] - 1) * (nums[1] - 1);
                return result;
            }

            Array.Sort(nums);
            result = (nums[nums.Length - 1] - 1) * (nums[nums.Length - 2] - 1);

            return result;
        }
    }
}
