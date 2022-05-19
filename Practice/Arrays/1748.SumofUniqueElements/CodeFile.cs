using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Arrays._1748.SumofUniqueElements
{
    public class CodeFile
    {
        public int SumOfUnique(int[] nums)
        {
            var result = 0;
            var map = new Dictionary<int, int>();

            foreach (var item in nums)
            {
                if (map.ContainsKey(item))
                {
                    map[item]++;
                }
                else
                {
                    map.Add(item, 1);
                }
            }

            result = map.Where(x => x.Value == 1).Select(x => x.Key).Sum();

            return result;
        }
    }
}
