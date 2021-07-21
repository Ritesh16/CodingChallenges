using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.LongestCommonPrefix
{
    public class CodeFile_DivideConquer
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length <= 0)
            {
                return "";
            }

            return FindLCP(strs, 0, strs.Length - 1);
        }

        private string FindLCP(string[] strs, int start, int end)
        {
            if (start == end)
            {
                return strs[start];
            }
            else
            {
                var mid = (start + end) / 2;
                var firstPrefix = FindLCP(strs, start, mid);
                var secondPrefix = FindLCP(strs, mid + 1, end);
                return LongestCommonPrefix(firstPrefix, secondPrefix);
            }

        }

        private string LongestCommonPrefix(string firstPrefix, string secondPrefix)
        {
            int minLength = Math.Min(firstPrefix.Length, secondPrefix.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (firstPrefix[i] != secondPrefix[i])
                {
                    return firstPrefix.Substring(0, i);
                }
            }

            return firstPrefix.Substring(0, minLength);
        }
    }
}
