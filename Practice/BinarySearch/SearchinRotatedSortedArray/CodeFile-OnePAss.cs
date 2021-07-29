using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearch.SearchinRotatedSortedArray
{
    class CodeFile_OnePAss
    {
        public int Search(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] >= nums[start])
                {
                    if (target >= nums[start] && target < nums[mid]) end = mid - 1;
                    else start = mid + 1;
                }
                else
                {
                    if (target <= nums[end] && target > nums[mid]) start = mid + 1;
                    else end = mid - 1;
                }
            }
            return -1;
        }
    }
}
