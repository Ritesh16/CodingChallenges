using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.ContainsDuplicate
{
    public class CodeFile
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var result = false;
            var hashSet = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashSet.Contains(nums[i]))
                {
                    result = true;
                    break;
                }

                hashSet.Add(nums[i]);
            }

            return result;
        }
    }
}
