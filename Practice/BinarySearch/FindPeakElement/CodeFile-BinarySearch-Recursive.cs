using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearch.FindPeakElement
{
    class CodeFile_BinarySearch_Recursive
    {
        public int FindPeakElement(int[] nums)
        {
            return Search(nums, 0, nums.Length - 1);
        }

        private int Search(int[] nums, int left, int right)
        {
            if (left == right)
            {
                return left;
            }

            var mid = (left + right) / 2;
            if (nums[mid] > nums[mid + 1])
            {
                return Search(nums, left, mid);
            }

            return Search(nums, mid + 1, right);
        }
    }
}
