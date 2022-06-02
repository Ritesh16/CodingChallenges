using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._1630.ArithmeticSubarrays
{
    public class CodeFile
    {
        public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
        {
            var result = new bool[l.Length];
            for (int i = 0; i < l.Length; i++)
            {
                var start = l[i];
                var end = r[i];

                if (end - start + 1 < 2)
                {
                    continue;
                }

                var firstSmall = int.MaxValue;
                var secondSmall = int.MaxValue;
                var largest = int.MinValue;

                var set = new HashSet<int>();
                for (int j = start; j <= end; j++)
                {
                    set.Add(nums[j]);

                    if (nums[j] < firstSmall)
                    {
                        secondSmall = firstSmall;
                        firstSmall = nums[j];
                    }
                    else if (nums[j] < secondSmall)
                    {
                        secondSmall = nums[j];
                    }

                    largest = Math.Max(largest, nums[j]);
                }

                if (firstSmall == secondSmall && set.Count != 1)
                {
                    continue;
                }

                if (firstSmall != secondSmall && set.Count != (end - start) + 1)
                {
                    continue;
                }

                int diff = secondSmall - firstSmall;
                bool isValid = true;
                for (int j = start; j <= end; j++)
                {
                    if (nums[j] != largest && !set.Contains(nums[j] + diff))
                    {
                        isValid = false;
                        break;
                    }
                }

                result[i] = isValid;
            }


            return result;
        }
    }
}
