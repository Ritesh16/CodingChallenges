using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearch.FindFirstLastPositionElementinSortedArray
{
    class CodeFile
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var first = Search(nums, target, true);
            if (first == -1)
            {
                return new int[] { -1, -1 };
            }

            var second = Search(nums, target, false);
            return new int[] { first, second };
        }

        private int Search(int[] nums, int target, bool firstOccurrence)
        {
            var begin = 0;
            var end = nums.Length - 1;

            while (begin <= end)
            {
                var mid = begin + (end - begin) / 2;

                if (nums[mid] == target)
                {
                    if (firstOccurrence)
                    {
                        if (mid == begin || nums[mid - 1] != target)
                        {
                            return mid;
                        }

                        end = mid - 1;
                    }
                    else
                    {
                        if (mid == end || nums[mid + 1] != target)
                        {
                            return mid;
                        }

                        begin = mid + 1;
                    }
                }
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    begin = mid + 1;
                }
            }

            return -1;
        }
    }
}
