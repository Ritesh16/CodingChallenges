using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._1464.MaxProductofTwoElementsArray
{
    public class CodeFile_Fast
    {
        public int MaxProduct(int[] nums)
        {
            int i = 0;

            for (int k = 1; k < nums.Length; k++)
            {
                if (nums[k] > nums[i]) i = k;
            }

            int j = i == 0 ? 1 : 0;
            for (int k = j + 1; k < nums.Length; k++)
            {
                if (nums[k] > nums[j] && k != i) j = k;
            }
            Console.WriteLine($"i = {i}, j = {j}");

            return (nums[i] - 1) * (nums[j] - 1);
        }
    }
}
