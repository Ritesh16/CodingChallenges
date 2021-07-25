using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Arrays.DistinctNumbersinEachSubarray_SlidingWindow
{
    class CodeFile
    {
        public int[] DistinctNumbers(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
            {
                return new int[0];
            }

            var ans = new int[nums.Length - k + 1];
            var left = 0;
            var right = 0;
            var dictionary = new Dictionary<int, int>();
            while (right < nums.Length)
            {
                if (dictionary.ContainsKey(nums[right]))
                {
                    dictionary[nums[right]]++;
                }
                else
                {
                    dictionary.Add(nums[right], 1);
                }

                right++;
                if (right - left == k)
                {
                    ans[left] = dictionary.Count;
                    dictionary[nums[left]]--;
                    if(dictionary[nums[left]] == 0)
                    {
                        dictionary.Remove(nums[left]);
                    }

                    left++;
                }
            }

            return ans;
        }

    }
}
