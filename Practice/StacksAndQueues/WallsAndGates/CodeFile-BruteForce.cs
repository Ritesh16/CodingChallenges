using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StacksAndQueues.WallsAndGates
{
    class CodeFile_BruteForce
    {
        private static int EMPTY = int.MaxValue;
        private static int GATE = 0;
        private static int WALL = -1;
        private static List<int[]> DIRECTIONS = new List<int[]> {
                new int[] { 1, 0 },
                new int[] { -1, 0 },
                new int[] { 0, 1 },
                new int[] { 0, -1 } };
        public void WallsAndGates(int[][] rooms)
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                for (int j = 0; j < rooms[i].Length; j++)
                {
                    if (rooms[i][j] == EMPTY)
                        rooms[i][j] = GetNearestDistance(rooms, i, j);
                }
            }
        }

        private int GetNearestDistance(int[][] rooms, int startRow, int startCol)
        {
            int m = rooms.Length;
            int n = rooms[0].Length;

            Queue<int[]> queue = new Queue<int[]>();
            queue.Enqueue(new int[] { startRow, startCol });
            int[,] distance = new int[m, n];

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                foreach (var direction in DIRECTIONS)
                {
                    var r = current[0] + direction[0];
                    var c = current[1] + direction[1];

                    if (r < 0 || c < 0 || r >= m || c >= n || rooms[r][c] == WALL || distance[r, c] != 0)
                    {
                        continue;
                    }

                    distance[r, c] = distance[current[0], current[1]] + 1;
                    if (rooms[r][c] == GATE)
                    {
                        return distance[r, c];
                    }

                    queue.Enqueue(new int[] { r, c });
                }
            }

            return int.MaxValue;
        }
    }
}
