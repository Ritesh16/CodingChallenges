using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.SquaresofSortedArray
{
    public class CodeFile
    {
        // Approach 1
        public int[] SortedSquares1(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }

            Array.Sort(nums);
            return nums;
        }

        // Approach 2
        public int[] SortedSquares(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;
            int[] result = new int[nums.Length];

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                int square = 0;
                if(Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    square = nums[left];
                    left++;
                }
                else
                {
                    square = nums[right];
                    right--;
                }

                result[i] = square * square;
            }

            return result;
        }

    }
}
