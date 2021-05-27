using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Maths.CountSubstringwith1DistinctLetter
{
    class CodeFile
    {
        public int CountLetters(string s)
        {
            var result = 1;
            var total = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    result += 1;
                }
                else
                {
                    result = 1;
                }

                total += result;
            }

            return total;
        }
    }
}
