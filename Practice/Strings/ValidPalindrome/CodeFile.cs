using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Strings.ValidPalindrome
{
    public class CodeFile
    {

        public bool IsPalindrome(string s)
        {
            var right = s.Length - 1;
            for (int left = 0; left < s.Length; left++)
            {
                while(left < right && !char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }

                while(left < right && !char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }

                if(char.ToLower(s[left]) != char.ToLower(s[right]))
                {
                    return false;
                }

                if (left >= right)
                {
                    break;
                }

                right--;

            }

            return true;
        }

        public bool IsPalindromeSecond(string s)
        {
            s = s.ToLower();
            var builder = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetterOrDigit(s[i]))
                {
                    builder.Append(s[i]);
                }
            }


            var reverString = builder.ToString().Reverse();
            
            return builder.ToString() == reverString;
        }
    }
}
