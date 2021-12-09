using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.FindTargetIndicesAfterSortingArray
{
    internal class CodeFile
    {
        public IList<int> TargetIndices(int[] nums, int target)
        {
            var output = new List<int>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    output.Add(i);
                }

                if (nums[i] > target)
                {
                    break;
                }
            }

            return output;
        }
    }
}
