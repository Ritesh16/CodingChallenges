using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDataType.Challenges.Permutation
{
    public class CodeFile
    {
        char[] result = new char[10];
        int[] characters = new int[10];

        public void Permutation(string input, int k)
        {
            if (k == input.Length)
            {
                // Print
                var output = new String(result);
                Console.WriteLine(output);
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (characters[i] == 0)
                    {
                        result[k] = input[i];
                        characters[i] = 1;
                        Permutation(input, k + 1);
                        characters[i] = 0;
                    }
                }
            }
        }
    }
}
