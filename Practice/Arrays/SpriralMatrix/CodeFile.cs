using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.SpriralMatrix
{
    class CodeFile
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var result = new List<int>();

            var rowCount = matrix.Length - 1;
            if (rowCount == -1) return result;

            int colCount = matrix[0].Length - 1;
            int rowStart = 0;
            int colStart = 0; ;
            while (rowStart <= rowCount && colStart <= colCount)
            {
                for (int i = colStart; i <= colCount; i++)
                {
                    result.Add(matrix[rowStart][i]);
                }

                for (int i = rowStart + 1; i <= rowCount; i++)
                {
                    result.Add(matrix[i][colCount]);
                }

                if (rowStart < rowCount && colStart < colCount)
                {
                    for (int i = colCount - 1; i > colStart; i--)
                    {
                        result.Add(matrix[rowCount][i]);
                    }

                    for (int i = rowCount; i > rowStart; i--)
                    {
                        result.Add(matrix[i][colStart]);
                    }
                }

                rowStart++;
                rowCount--;
                colStart++;
                colCount--;
            }
            return result;
        }
    }
}
