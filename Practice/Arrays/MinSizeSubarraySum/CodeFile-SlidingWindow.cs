using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.MinSizeSubarraySum
{
    class CodeFile_SlidingWindow
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            var left = 0;
            var right = 0;
            var sum = nums[0];
            var result = int.MaxValue;

            while (left != nums.Length)
            {
                if (sum < target)
                {
                    if (right < nums.Length - 1)
                    {
                        right++;
                        sum += nums[right];
                    }
                    else
                    {
                        sum -= nums[left];
                        left++;
                    }
                    continue;
                }

                result = Math.Min(right - left + 1, result);
                sum -= nums[left];
                left++;
            }

            return result == int.MaxValue ? 0 : result;
        }
    }
}
