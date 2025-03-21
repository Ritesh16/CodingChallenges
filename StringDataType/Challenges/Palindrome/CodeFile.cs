using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDataType.Challenges.Palindrome
{
    public class CodeFile
    {
        public bool IsPalindrome(string s)
        {
            var right = s.Length - 1;
            for (int left = 0; left < s.Length; left++)
            {
                while (left < right && !char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }

                while (left < right && !char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }

                if (char.ToLower(s[left]) != char.ToLower(s[right]))
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
    }
}
