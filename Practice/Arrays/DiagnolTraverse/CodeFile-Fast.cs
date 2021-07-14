using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.DiagnolTraverse
{
    class CodeFile_Fast
    {
        public int[] FindDiagonalOrder(int[][] mat)
        {
            var row = mat.Length;
            if (row == 0 || mat == null) return new int[0];

            var col = mat[0].Length;
            var result = new int[row * col];

            int i = 0, j = 0, k = 0;
            while (i < row && j < col)
            {
                result[k++] = mat[i][j];
                if ((i + j) % 2 == 0)
                {
                    if (j == col - 1) i++;
                    else if (i == 0) j++;
                    else
                    {
                        i--;
                        j++;
                    }
                }
                else
                {
                    if (i == row - 1) j++;
                    else if (j == 0) i++;
                    else
                    {
                        i++;
                        j--;
                    }
                }
            }

            return result;
        }
    }
}
