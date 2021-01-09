using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.RemoveDuplicatesFromSortedArray
{
    public class CodeFile
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            var result = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if(nums[i] != nums[result])
                {
                    result++;
                    nums[result] = nums[i];
                   
                }
            }

            result = result + 1;
            return result;
        }
    }
}
