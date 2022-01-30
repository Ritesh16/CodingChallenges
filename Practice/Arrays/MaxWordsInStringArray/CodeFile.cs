using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Arrays.MaxWordsInStringArray
{
    internal class CodeFile
    {
        public int MostWordsFound(string[] sentences)
        {
            int max = 0;
            foreach (string sentence in sentences)
            {
                var wordsArray = sentence.Split(' ');
                max = Math.Max(max, wordsArray.Count());
            }

            return max;
        }
    }
}
