using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearch.SearchinRotatedSortedArray
{
    class CodeFile
    {
        int[] nums;
        int target;
        public int Search(int[] nums, int target)
        {
            this.nums = nums;
            this.target = target;

            if (nums.Length == 1) return nums[0] == target ? 0 : -1;

            var rotateIndex = GetRotateIndex(0, nums.Length - 1);

            if (nums[rotateIndex] == target) return rotateIndex;

            if (rotateIndex == 0)
            {
                return Search(0, nums.Length - 1);
            }

            if (target < nums[0])
            {
                return Search(rotateIndex, nums.Length - 1);
            }

            return Search(0, rotateIndex);

        }

        private int Search(int left, int right)
        {
            // Binary Search

            while (left <= right)
            {
                int pivot = (left + right) / 2;
                if (nums[pivot] == target) return pivot;

                if (nums[pivot] > target)
                {
                    right = pivot - 1;
                }
                else
                {
                    left = pivot + 1;
                }
            }

            return -1;
        }

        private int GetRotateIndex(int left, int right)
        {
            if (nums[left] < nums[right])
                return 0;

            while (left <= right)
            {
                int pivot = (left + right) / 2;
                if (nums[pivot] > nums[pivot + 1])
                {
                    return pivot + 1;
                }
                else
                {
                    if (nums[pivot] < nums[left])
                    {
                        right = pivot - 1;
                    }
                    else
                    {
                        left = pivot + 1;
                    }
                }
            }

            return 0;
        }
    }
}
