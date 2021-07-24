using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Strings.ReverseWordsinStringIII
{
    class CodeFile
    {
        public string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            var sb = new StringBuilder();
            var start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    continue;
                }

                while (i < s.Length && s[i] != ' ')
                {
                    i++;
                }

                var input = s.Substring(start, i - start);

                input = Reverse(input);

                sb.Append(input.ToString() + " ");
                start = i;
            }

            return sb.ToString().Trim();
        }

        public string Reverse(string input)
        {
            var word = new StringBuilder();
            for (int j = input.Length - 1; j >= 0; j--)
            {
                word.Append(input[j]);
            }

            return word.ToString().Trim();
        }
    }
}
