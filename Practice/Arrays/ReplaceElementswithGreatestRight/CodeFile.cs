using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.ReplaceElementswithGreatestRight
{
    public class CodeFile
    {
        // Brute Force
        public int[] ReplaceElements(int[] arr)
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
    }
}
