using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Arrays.PivotIndex
{
    class CodeFile_SingleLoop
    {
        public int PivotIndex(int[] nums)
        {
            int sum = 0, leftSum = 0;
            sum = nums.Sum();
            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == sum - leftSum - nums[i]) return i;

                leftSum += nums[i];
            }

            return -1;
        }
    }
}
