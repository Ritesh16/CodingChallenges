using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        // Swapping
        public void Permutation2(char[] input, int low, int high)
        {
            if(low == high)
            {
                var output = new String(input);
                Console.WriteLine($"Output : {output}");
            }
            else
            {
                for (int i = low; i <= high; i++)
                {
                    input = Swap(input, low, i);
                    Permutation2(input, low + 1, high);
                    input = Swap(input, low, i);
                }
            }

        }

        public char[] Swap(char[] input, int low, int index)
        {
            if(low == index)
            {
                return input;
            }

            var temp = input[low];
            input[low] = input[index];
            input[index] = temp;

            return input;
        }
    }
}
