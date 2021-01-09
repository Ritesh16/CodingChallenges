using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.ReverseString
{
    public class CodeFile
    {
        public char[] ReverseString(char[] s)
        {
            var length = s.Length - 1;
            char temp;

            for (int i = 0; i < s.Length/2; i++)
            {
                temp = s[i];
                s[i] = s[length];
                s[length] = temp;
                length = length-1;
            }

            return s;
        }
    }
}
