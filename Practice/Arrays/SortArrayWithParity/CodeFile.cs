using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.SortArrayWithParity
{
    public class CodeFile
    {
        public int[] SortArrayByParity(int[] A)
        {
            var i = 0;
            var j = A.Length - 1;
            var temp = 0;

            while (i <= j)
            {
                if (A[i] % 2 != 0 && A[j] % 2 == 0)
                {
                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                    j--;
                    i++;
                }

                if (A[i] % 2 != 0 && A[j] % 2 != 0)
                {
                    j--;
                }

                if (A[i] % 2 == 0) i++;

            }

            return A;
        }
    }
}
