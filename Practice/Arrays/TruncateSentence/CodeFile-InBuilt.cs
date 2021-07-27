using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.TruncateSentence
{
    class CodeFile_InBuilt
    {
        public string TruncateSentence(string s, int k)
        {
            var array = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var sb = new StringBuilder();
            for (int i = 0; i < k ; i++)
            {
                sb.Append(array[i] + " ");
            }

            return sb.ToString();
        }
    }
}
