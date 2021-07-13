using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.PivotIndex
{
    class CodeFile
    {
        public int PivotIndex(int[] nums)
        {
            int sum = 0, leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == sum - leftSum - nums[i]) return i;

                leftSum += nums[i];
            }

            return -1;
        }
    }
}
