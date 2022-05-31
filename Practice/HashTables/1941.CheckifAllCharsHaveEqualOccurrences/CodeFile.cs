using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.HashTables._1941.CheckifAllCharsHaveEqualOccurrences
{
    public class CodeFile
    {
        public bool AreOccurrencesEqual(string s)
        {
            var array = new int[26];
            var m = 0;
            foreach (var c in s)
            {
                var index = c - 'a';
                array[index]++;

                m = index;
            }

            for (int i = 0; i < 26; i++)
            {
                if (array[i] != 0 && array[i] != array[m])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
