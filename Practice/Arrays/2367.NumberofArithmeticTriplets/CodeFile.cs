using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays._2367.NumberofArithmeticTriplets
{
    public class CodeFile
    {
        public int ArithmeticTriplets(int[] nums, int diff)
        {
            var hashMap = new HashSet<int>();
            var result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                hashMap.Add(nums[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var num1 = nums[i] + diff;
                var num2 = num1 + diff;

                if (hashMap.Contains(num1) && hashMap.Contains(num2))
                {
                    result++;
                }
            }

            return result;
        }
    }
}
