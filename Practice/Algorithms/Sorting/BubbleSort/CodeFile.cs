using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Algorithms.Sorting.BubbleSort
{
    public class CodeFile
    {
        public int[] Sort(int[] input)
        {
            var temp = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        temp = input[j + 1];
                        input[j + 1] = input[j];
                        input[j] = temp;
                    }
                }
            }

            return input;
        }
    }
}
