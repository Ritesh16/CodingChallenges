using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.CountNumberofConsistentStrings
{
    class CodeFile
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            var hashSet = new HashSet<char>(allowed);
            var count = words.Length;

            for (int i = 0; i < words.Length; i++)
            {
                foreach (var c in words[i])
                {
                    if (!hashSet.Contains(c))
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
