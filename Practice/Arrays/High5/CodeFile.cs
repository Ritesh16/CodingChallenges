using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Arrays.High5
{
    public class CodeFile
    {
        public int[][] HighFive(int[][] items)
        {
            var dictionary = new SortedDictionary<int, List<int>>();

            for (int i = 0; i < items.Length; i++)
            {
                if(dictionary.ContainsKey(items[i][0]))
                {
                    dictionary[items[i][0]].Add(items[i][1]);   
                }
                else
                {
                    dictionary.Add(items[i][0], new List<int> { items[i][1] });
                }
            }


            var output = new int[dictionary.Count][];
            var num = 0;
            foreach (var item in dictionary)
            {
                output[num] = new int[2];
                output[num][0] = item.Key;
                output[num][1] = item.Value.OrderByDescending(x => x).Take(5).Sum() / 5;
                num++;
            }

            return output;
        }
    }
}
