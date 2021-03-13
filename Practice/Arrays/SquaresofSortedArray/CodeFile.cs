using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.SquaresofSortedArray
{
    public class CodeFile
    {
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }

            Array.Sort(nums);
            return nums;
        }
    }
}
