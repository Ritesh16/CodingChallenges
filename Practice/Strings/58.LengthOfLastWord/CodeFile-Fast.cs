using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings._58.LengthOfLastWord
{
    public class CodeFile_Fast
    {
        public int LengthOfLastWord(string s)
        {
            s = s.TrimEnd();

            var n = s.LastIndexOf(' ');

            return s.Length - n - 1;
        }
    }
}
