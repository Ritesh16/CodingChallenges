using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.ReverseWordsinStringII
{
    public class CodeFile
    {
        public void ReverseWords(char[] s)
        {
            Reverse(s, 0, s.Length - 1);

            ReverseWordsOnly(s);

        }

        private void ReverseWordsOnly(char[] s)
        {
            var start = 0;
            var end = 0;
            var n = s.Length;

            while (start < n)
            {
                while (end < n && s[end] != ' ')
                {
                    end++;
                }

                Reverse(s, start, end - 1);
                start = end + 1;
                end++;
            }
        }

        private void Reverse(char[] s, int start, int end)
        {
            while (start < end)
            {
                char temp = s[start];
                s[start] = s[end];
                start++;
                s[end] = temp;
                end--;
            }
        }
    }
}
