using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.ReverseWordsinString
{
    class CodeFile
    {
        public string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            var data = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var builder = new StringBuilder();
            for (int i = data.Length - 1; i >= 0; i--)
            {
                builder.Append(data[i]);
                builder.Append(" ");
            }

            return builder.ToString().Trim();
        }
    }
}
