using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.DuplicateZeros
{
    public class CodeFile
    {
        public void DuplicateZeros1(int[] arr)
        {
            int i = 0;
            int j = 0;

            var output = new int[arr.Length];
     
            while (i < arr.Length)
            {
                output[i] = arr[j];
                if (output[i] == 0 && i < arr.Length-1)
                {
                    output[i + 1] = 0;
                    i++;
                }

                i++;
                j++;
            }

            Array.Copy(output, arr, arr.Length);
        }
        public void DuplicateZeros(int[] arr)
        {
            var count = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                return;
            }


            var newArray = new int[arr.Length + count];

            var j = 0;
            var k = 0;
            while (k < arr.Length)
            {
                newArray[j] = arr[k];
                if (arr[k] == 0)
                {
                    newArray[j + 1] = 0;
                    j = j + 1;
                }

                j = j + 1;
                k = k + 1;
            }


            Array.Copy(newArray, arr, arr.Length);
        }
    }
}
