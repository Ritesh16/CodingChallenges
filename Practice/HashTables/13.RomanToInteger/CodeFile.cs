using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.HashTables._13.RomanToInteger
{
    public class CodeFile
    {
        public int RomanToInt(string s)
        {
            var output = 0;
            var last = 0;
            var map = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            for (var i = s.Length - 1; i >= 0; i--)
            {
                if (last < map[s[i]])
                {
                    output += map[s[i]];
                }
                else
                {
                    output -= map[s[i]];
                }

                last = map[s[i]];
            }

            return output;
        }
    }
}
