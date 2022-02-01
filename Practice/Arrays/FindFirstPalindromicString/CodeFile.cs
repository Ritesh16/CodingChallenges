using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.FindFirstPalindromicString
{
    public class CodeFile
    {
        public string FirstPalindrome(string[] words)
        {
            var result = "";
            foreach (var word in words)
            {
                if (IsPalindrome(word))
                {
                    result = word;
                    break;
                }
            }

            return result;
        }

        public bool IsPalindrome(string word)
        {
            var i = 0;
            var j = word.Length-1;
            while (i <= j)
            {
                if(word[i] != word[j])
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }
    }
}
