using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StacksAndQueues.NumberofIslands
{
    public class CodeFile_DFS
    {
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            int count = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        DFS(grid, i, j);
                        count++;
                    }
                }
            }

            return count;
        }

        private void DFS(char[][] grid, int r, int c)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;

            if (r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] == '0')
            {
                return;
            }

            grid[r][c] = '0';
            DFS(grid, r + 1, c);
            DFS(grid, r - 1, c);
            DFS(grid, r, c + 1);
            DFS(grid, r, c - 1);
        }
    }
}
