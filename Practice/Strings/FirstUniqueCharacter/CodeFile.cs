using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.FirstUniqueCharacter
{
    public class CodeFile
    {
        // Regular solution
        public int FirstUniqChar(string s)
        {
            var result = -1;
            var length = s.Length;
            var dictionary = new Dictionary<char, int>();
            for (int i = 0; i < length; i++)
            {
                if (dictionary.ContainsKey(s[i]))
                {
                    dictionary[s[i]]++;
                }
                else
                {
                    dictionary.Add(s[i], 1);
                }
            }

            for (int i = 0; i < length; i++)
            {
                if (dictionary[s[i]] == 1)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        // Tricky solution
        public int FirstUniqChar1(string s)
        {
            var result = -1;
            var length = s.Length;
            var array = new int[26];
            for (int i = 0; i < length; i++)
            {
                var index = s[i] - 'a';
                array[index]++;
            }

            for (int i = 0; i < length; i++)
            {
                var index = s[i] - 'a';
                if (array[index] == 1)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
    }
}
