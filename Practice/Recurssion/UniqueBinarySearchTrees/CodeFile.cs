using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.UniqueBinarySearchTrees
{
    class CodeFile
    {
        public int NumTrees(int n)
        {
            int[] array = new int[n + 1];
            array[0] = 0;
            array[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    array[i] += array[j - 1] * array[i - j];
                }
            }

            return array[n];
        }
    }
}
