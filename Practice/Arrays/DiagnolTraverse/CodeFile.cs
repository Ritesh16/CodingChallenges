using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.DiagnolTraverse
{
    class CodeFile
    {
        public int[] FindDiagonalOrder(int[][] matrix)
        {
            var row = matrix.Length;
            if (row == 0) return new int[0];

            var col = matrix[0].Length;
            var result = new List<int>();
            var count = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == 0 || j == col - 1)
                    {
                        var elements = new List<int>();
                        var currentI = i;
                        var currentJ = j;

                        while (currentI < row && currentJ >= 0)
                        {
                            elements.Add(matrix[currentI][currentJ]);
                            currentI++;
                            currentJ--;
                        }

                        if (count % 2 == 0)
                        {
                            elements.Reverse();
                        }

                        count++;

                        result.AddRange(elements);
                    }
                }
            }

            return result.ToArray();
        }
    }
}
