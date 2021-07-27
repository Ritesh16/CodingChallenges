using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.CountNumberofConsistentStrings
{
    class CodeFile_Fast
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            var allowedHash = new bool[26];
            for (int i = 0; i < allowed.Length; i++)
            {
                allowedHash[allowed[i] - 'a'] = true;
            }

            var count = words.Length;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!allowedHash[words[i][j] - 'a'])
                    {
                        count--;
                        break;
                    }
                }
            }

            return count;
        }
    }
}
