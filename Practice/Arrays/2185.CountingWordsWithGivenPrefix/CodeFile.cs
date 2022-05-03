using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Arrays._2185.CountingWordsWithGivenPrefix
{
    public class CodeFile
    {
        public int PrefixCount(string[] words, string pref)
        {
            return words.Count(w => w.StartsWith(pref));
        }
    }
}
