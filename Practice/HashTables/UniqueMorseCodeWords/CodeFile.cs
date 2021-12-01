using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.HashTables.UniqueMorseCodeWords
{
    internal class CodeFile
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            var array = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            var map = new HashSet<string>();
            var morse = string.Empty;
            foreach (var word in words)
            {
                morse = String.Empty;
                foreach (var w in word)
                {
                    var c = w - 'a';
                    morse += array[c];
                }

                map.Add(morse);
            }

            return map.Count();
        }
    }
}
