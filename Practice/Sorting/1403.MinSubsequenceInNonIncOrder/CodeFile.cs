using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._1403.MinSubsequenceInNonIncOrder
{
    public class CodeFile
    {
        public IList<int> MinSubsequence(int[] nums)
        {
            var result = new List<int>();
            Array.Sort(nums);

            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            var maxSum = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                maxSum += nums[i];
                sum -= nums[i];
                result.Add(nums[i]);
                if (sum < maxSum)
                {
                    break;
                }

               
            }

            return result;
        }
    }
}
