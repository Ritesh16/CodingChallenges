using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearch.FindMinRotatedSortedArray
{
    class CodeFile
    {
        public int FindMin(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            if (nums[0] < nums[nums.Length - 1])
            {
                return nums[0];
            }

            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    return nums[mid + 1];
                }

                if (nums[mid - 1] > nums[mid])
                {
                    return nums[mid];
                }

                if (nums[mid] > nums[0])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}
