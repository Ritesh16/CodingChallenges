using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDataType.Challenges.CountingWovelsAndWords
{
    public class CodeFile
    {
        public void Count(string input)
        {
            var lower = input.ToLower();
            var vowels = 0;
            var words = 0;
            for (int i = 0; i < lower.Length; i++)
            {
                var c = lower[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowels++;
                }
                else if (lower[i] == ' ' && lower[i - 1] != ' ')
                {
                    words++;
                }
            }

            Console.WriteLine($"There are total {vowels} vowels & {words+1} words.");
        }
    }
}
