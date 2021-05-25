using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.HashTables
{
    public class CodeFile
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            //var jewelSet = new HashSet<char>();
            //for (int i = 0; i < jewels.Length; i++)
            //{
            //    jewelSet.Add(jewels[i]);
            //}

            //int result = 0;
            //for (int i = 0; i < stones.Length; i++)
            //{
            //    if (jewelSet.Contains(stones[i]))
            //    {
            //        result++;
            //    }
            //}

            //return result;

            var jewelSet = new HashSet<char>();
            foreach (var j in jewels)
            {
                jewelSet.Add(j);
            }

            int result = 0;
            foreach (var s in stones)
            {
                if (jewelSet.Contains(s))
                {
                    result++;
                }
            }

            return result;
        }
}
