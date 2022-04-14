using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays._59.SpiralMatrixll
{
    public class CodeFile
    {
        public int[][] GenerateMatrix(int n)
        {
            var result = new int[n][];
            for (int i = 0; i < n; i++)
                result[i] = new int[n];

            int rowLowEnd = 0, columnLowEnd = 0;
            int rowHighEnd = result.Length - 1, columnHighEnd = result[0].Length - 1;
            var count = 1;

            while (rowLowEnd <= rowHighEnd && columnLowEnd <= columnHighEnd)
            {
                for (int i = columnLowEnd; i <= columnHighEnd; i++)
                {
                    result[rowLowEnd][i] = count++;
                }

                for (int i = rowLowEnd + 1; i <= rowHighEnd; i++)
                {
                    result[i][columnHighEnd] = count++;
                }

                if (rowLowEnd < rowHighEnd && columnLowEnd < columnHighEnd)
                {
                    for (int i = columnHighEnd - 1; i > columnLowEnd; i--)
                    {
                        result[rowHighEnd][i] = count++;
                    }

                    for (int i = rowHighEnd; i > rowLowEnd; i--)
                    {
                        result[i][columnLowEnd] = count++;
                    }
                }

                rowLowEnd++;

                rowHighEnd--;

                columnLowEnd++;
                columnHighEnd--;
            }

            return result;
        }
    }
}
