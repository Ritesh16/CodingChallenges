using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.HashTables._961.N_RepeatedElementin2NArray
{
    public class CodeFile
    {
        public int RepeatedNTimes(int[] nums)
        {
            var result = int.MinValue;
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    map[nums[i]]++;
                    return nums[i];
                }
                else
                {
                    map.Add(nums[i], 1);
                }
            }

            return result;
        }
    }
}
