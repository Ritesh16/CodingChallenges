using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearch.FindPeakElement
{
    class CodeFile_LinearSearch
    {
        public int FindPeakElement(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    return i;
                }
            }

            return nums.Length - 1;
        }
    }
}
