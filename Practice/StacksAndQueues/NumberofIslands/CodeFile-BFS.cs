using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StacksAndQueues.NumberofIslands
{
    public class CodeFile_BFS
    {
        private static List<int[]> DIRECTIONS = new List<int[]> {
                new int[] { 1, 0 },
                new int[] { -1, 0 },
                new int[] { 0, 1 },
                new int[] { 0, -1 } };
        public int numIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            int count = 0;
            int rows = grid.Length;
            int cols = grid[0].Length;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count++;
                        Queue<int[]> queue = new Queue<int[]>();
                        queue.Enqueue(new int[] { i, j });
                        while (queue.Count != 0)
                        {
                            var current = queue.Dequeue();
                            foreach (var direction in DIRECTIONS)
                            {
                                
                                int r = current[0] + direction[0];
                                int c = current[1] + direction[1];

                                if (r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] == '0')
                                {
                                    continue;
                                }

                                grid[r][c] = '0';
                                queue.Enqueue(new int[] { r, c });
                            }
                        }
                    }
                }
            }

            return count;
        }
    }
}
