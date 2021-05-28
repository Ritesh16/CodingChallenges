using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.SplitinBalancedStrings
{
    class CodeFile
    {
        public int BalancedStringSplit(string s)
        {
            var result = 0;
            var temp = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                {
                    temp++;
                }
                else
                {
                    temp--;
                }

                if (temp == 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
