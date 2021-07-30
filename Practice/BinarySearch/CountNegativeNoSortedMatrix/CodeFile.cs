using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearch.CountNegativeNoSortedMatrix
{
    class CodeFile
    {
        public int CountNegatives(int[][] grid)
        {
            int rows = grid.Length;
            int columns = grid[0].Length;

            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                while (columns > 0)
                {
                    if (grid[i][columns - 1] >= 0)
                    {
                        break;
                    }

                    count += rows - i;
                    columns--;
                }
            }

            return count;
        }
    }
}
