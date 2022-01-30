using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.HashTables.CountNumberofPairs
{
    internal class CodeFile
    {
        public int CountKDifference(int[] nums, int k)
        {

            if (nums == null || nums.Length < 2)
            {
                return 0;
            }

            var result = 0;
            var map = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (map.ContainsKey(item - k))
                {
                    result += map[item - k];
                }

                if (map.ContainsKey(item + k))
                {
                    result += map[item + k];
                }

                if (map.ContainsKey(item))
                {
                    map[item]++;
                }
                else
                {
                    map.Add(item, 1);
                }

            }

            return result;
        }
    }
}
