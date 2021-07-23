using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.MinSizeSubarraySum
{
    public class CodeFile
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            var result = 0;
            var sum = 0;
            var r = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum >= target)
                    {
                        r = j - i + 1;
                        if (result == 0 || result > r)
                        {
                            result = r;
                        }

                        break;
                    }
                }

                sum = 0;
            }

            return result;
        }
    }
}
