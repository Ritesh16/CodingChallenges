using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.ReverseWordsinString
{
    class CodeFile_WithoutSplit
    {
        // Split creates array. To avoid extra array(memory), try not to use Split
        public string ReverseWords(string s)
        {
            if (s == "")
                return s;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    continue;

                int start = i;
                while (i < s.Length && s[i] != ' ')
                    i++;

                if (sb.Length == 0)
                    sb.Append(s.Substring(start, i - start));
                else
                    sb.Insert(0, s.Substring(start, i - start) + " ");
            }

            return sb.ToString();
        }
    }
}
