using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.Single_RowKeyboard
{
    public class CodeFile
    {
        public int CalculateTime(string keyboard, string word)
        {
            var dictionary = new Dictionary<char, int>();
            for (int i = 0; i < keyboard.Length; i++)
            {
                dictionary.Add(keyboard[i], i);
            }

            int result = 0;
            int last = 0;
            int temp = 0;
            for (int i = 0; i < word.Length; i++)
            {
                var c = word[i];
                temp = Math.Abs(dictionary[c] - last);
                result = result + temp;
                last = dictionary[c];
            }

            return result;
        }
    }
}
