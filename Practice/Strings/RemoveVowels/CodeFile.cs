using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.RemoveVowels
{
    public class CodeFile
    {
        public string RemoveVowels(string s)
        {
            return s.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");
        }
    }
}
