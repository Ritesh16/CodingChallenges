using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings._58.LengthOfLastWord
{
    public class CodeFile
    {
        public int LengthOfLastWord(string s)
        {
            s = s.TrimEnd();
            var legnth = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    break;
                }

                legnth++;
            }

            return legnth;
        }
    }
}
