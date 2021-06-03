using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.CheckStringsAreEqual
{
    class CodeFile
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            return string.Join("", word1) == string.Join("", word2);
        }

    }
}
