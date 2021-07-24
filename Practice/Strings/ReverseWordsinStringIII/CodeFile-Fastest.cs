using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.ReverseWordsinStringIII
{
    class CodeFile_Fastest
    {
        public string ReverseWords(string s)
        {
            Stack<char> stack = new Stack<char>();
            StringBuilder sb = new StringBuilder(s.Length);
            foreach (var c in s)
            {
                if (c == ' ')
                {
                    while (stack.Count > 0)
                    {
                        sb.Append(stack.Pop());
                    }

                    sb.Append(c);
                    continue;
                }

                stack.Push(c);
            }

            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }

            return sb.ToString();
        }
    }
}
