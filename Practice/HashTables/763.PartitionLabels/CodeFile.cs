using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.HashTables._763.PartitionLabels
{
    public class CodeFile
    {
        public IList<int> PartitionLabels(string S)
        {
            var lastIndexArray = new int[26];
            var output = new List<int>();
            for (var i = 0; i < S.Length; i++)
            {
                lastIndexArray[S[i] - 'a'] = i;
            }

            var count = 0;

            while (count < S.Length)
            {
                var begin = count;
                var lastIndex = lastIndexArray[S[count] - 'a'];

                while (count < lastIndex)
                {
                    lastIndex = Math.Max(lastIndexArray[S[count] - 'a'], lastIndex);
                    count++;

                    if (lastIndex == S.Length - 1)
                    {
                        count = lastIndex;
                        break;
                    }
                }

                output.Add(count - begin + 1);

                count++;
            }

            return output;
        }
    }
}
