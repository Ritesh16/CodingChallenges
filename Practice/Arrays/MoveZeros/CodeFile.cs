using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.MoveZeros
{
    public class CodeFile
    {
        public int[] MoveZeroes(int[] nums)
        {
            var length = nums.Length;
            var pointer = 0;

            for (int i = 0; i < length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[pointer] = nums[i];
                    pointer++;
                }
            }

            for (int i = pointer; i < length; i++)
            {
                nums[i] = 0;
            }

            return nums;
        }
    }
}
