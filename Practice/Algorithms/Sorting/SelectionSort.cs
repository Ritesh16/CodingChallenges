using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Algorithms.Sorting
{
    public class SelectionSort
    {
        public int[] Sort(int[] input)
        {
            var temp = 0;
            var smallest = 0;

            for (int i = 0; i < input.Length; i++)
            {
                smallest = i;
                for (int j = i+ 1; j < input.Length; j++)
                {
                    if (input[j] < input[smallest])
                        smallest = j;
                }

                temp = input[smallest];
                input[smallest] = input[i];
                input[i] = temp;
            }

            return input;
        }
    }
}
