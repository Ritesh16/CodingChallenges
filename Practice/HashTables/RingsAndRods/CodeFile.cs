using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.HashTables.RingsAndRods
{
    internal class CodeFile
    {
        public int CountPoints(string rings)
        {
            HashSet<char>[] hashSetArray = new HashSet<char>[10];
            for (int i = 0; i < 10; i++)
            {
                hashSetArray[i] = new HashSet<char>();
            }

            var result = 0;

            for (int i = 0; i < rings.Length; i = i + 2)
            {
                var index = rings[i + 1] - '0';

                hashSetArray[index].Add(rings[i]);
            }

            result = hashSetArray.Count(x => x.Count == 3);

            return result;
        }
    }
}
