using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.TruncateSentence
{
    public class CodeFile
    {
        public string TruncateSentence(string s, int k)
        {
            int count = 0;
            int start = 0;
            int wordCount = 0;
            var sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    sb.Append(s.Substring(start, wordCount) + " ");
                    start = i + 1;
                    count++;
                    wordCount = 0;
                }
                else
                {
                    wordCount++;
                }

                if (count == k)
                {
                    break;
                }
            }

            if (count != k)
            {
                sb.Append(s.Substring(start, wordCount));
            }

            return sb.ToString().Trim();
        }
    }
}
