using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.DuplicateZeros
{
    public class CodeFile
    {
        public void DuplicateZeros(int[] arr)
        {
            int i = 0;
            int j = 0;
            int next = 0;

            while (i < arr.Length - 1)
            {
                if (arr[i] == 0)
                {
                    next = arr[i + 1];
                    arr[i + 1] = 0;
                }

                i++;
                j++;
            }
        }
        public void DuplicateZeros_ExtraMemory(int[] arr)
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


            arr = newArray;
        }
    }
}
