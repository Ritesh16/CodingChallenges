using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.FindNumbersDisappearedinArray
{
    public class CodeFile
    {
        public IList<int> FindDisappearedNumbers1(int[] nums)
        {
            // Using additional memory
            var output = new List<int>();
            var hashSet = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                hashSet.Add(nums[i]);
            }

            for (int i = 1; i <= nums.Length; i++)
            {

                if (!hashSet.Contains(i))
                {
                    output.Add(i);
                }
            }

            return output;
        }
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var output = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var newindex = Math.Abs(nums[i]) - 1;

                if (nums[newindex] > 0) nums[newindex] *= -1;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    output.Add(i + 1);
                }
            }

            return output;
        }
    }
}
