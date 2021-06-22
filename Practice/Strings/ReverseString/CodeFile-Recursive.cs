using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.ReverseString
{
    class CodeFile_Recursive
    {
        public void ReverseString(char[] s)
        {
            Helper(s, 0, s.Length - 1);
        }

        private void Helper(char[] s, int left, int right)
        {
            if (left >= right) return;

            var temp = s[left];
            s[left] = s[right];
            s[right] = temp;

            left++;
            right--;
            Helper(s, left, right);
        }
    }
}
