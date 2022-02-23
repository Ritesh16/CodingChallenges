using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.HashTables._1370.IncreasingDecreasingString
{
    public class CodeFile
    {
        public string SortString(string s)
        {
            int[] counts = new int[26];
            foreach (var c in s)
            {
                counts[c - 'a']++;
            }

            StringBuilder sb = new StringBuilder(s.Length);
            int direction = 1;
            int idx = 0;

            while (sb.Length != s.Length)
            {
                if (idx == 26 || idx == -1)
                {
                    direction = -direction;
                    idx += direction;
                }

                if (counts[idx] > 0)
                {
                    counts[idx]--;
                    sb.Append((char)(idx + 'a'));
                }

                idx += direction;
            }

            return sb.ToString();
        }
    }
}
