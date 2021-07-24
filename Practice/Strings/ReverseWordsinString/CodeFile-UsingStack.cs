using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.ReverseWordsinString
{
    class CodeFile_UsingStack
    {
        public string ReverseWords(string s)
        {

            s = s.Trim().TrimStart();

            string[] arr = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>();

            foreach (string str in arr)
            {
                stack.Push(str);
            }

            StringBuilder sb = new StringBuilder();
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
                sb.Append(" ");
            }

            return sb.ToString().Trim();
            //return String.Join(' ', stack);
        }
    }
}
