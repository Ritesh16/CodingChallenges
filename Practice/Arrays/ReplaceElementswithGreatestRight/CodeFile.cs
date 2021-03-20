using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.ReplaceElementswithGreatestRight
{
    public class CodeFile
    {
        // Brute Force
        public int[] ReplaceElements1(int[] arr)
        {
            int largest = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                largest = arr[i + 1];
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    if (largest < arr[j + 1])
                    {
                        largest = arr[j + 1];
                    }
                }

                arr[i] = largest;
            }


            arr[arr.Length - 1] = -1;

            return arr;
        }

        public int[] ReplaceElements(int[] arr)
        {
            if (arr.Length == 0)
            {
                return arr;
            }

            var current = 0;
            var largest = arr[arr.Length - 1];
            var pointer = arr.Length - 2;
            while (pointer >= 0)
            {
                current = arr[pointer];
                arr[pointer] = largest;
                if (largest < current)
                {
                    largest = current;
                }

                pointer--;
            }

            arr[arr.Length - 1] = -1;
            return arr;
        }
    }
}
