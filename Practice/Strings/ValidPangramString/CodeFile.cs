using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings
{
    class CodeFile
    {
        public bool CheckIfPangram(string sentence)
        {
            var cnt = new int[26];
            var total = 0;
            foreach (var ch in sentence)
            {
                if (++cnt[ch - 'a'] == 1)
                {
                    total++;
                }
            }
            return total == 26;
        }
    }
}
