using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Arrays._2418.SortthePeople
{
    public class CodeFile
    {
        public string[] SortPeople(string[] names, int[] heights)
        {
            var map = new Dictionary<int, string>();
            for (var i = 0; i < names.Length; i++)
            {
                map.Add(heights[i], names[i]);
            }

            Array.Sort(heights);

            var output = new string[names.Length];
            var index = 0;
            for (int i = heights.Length - 1; i >= 0; i--)
            {
                output[index] = map[heights[i]];
                index++;
            }

            return output;
        }
    }
}
