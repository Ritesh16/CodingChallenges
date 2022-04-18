using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays._1979._FindGCDOfArray
{
    public class CodeFile
    {
        public int FindGCD(int[] nums)
        {
            Array.Sort(nums);
            var min = nums[0];
            var max = nums[nums.Length - 1];

            for (int i = min; i > 1; i--)
            {
                if (min % i == 0 && max % i == 0)
                {
                    return i;
                }
            }

            return 1;
        }
    }
}
