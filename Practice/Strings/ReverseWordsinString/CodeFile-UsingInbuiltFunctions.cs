using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.ReverseWordsinString
{
    class CodeFile_UsingInbuiltFunctions
    {
        public string ReverseWords(string s)
        {

            string[] arr = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(arr);

            return String.Join(" ", arr);
        }
    }
}
