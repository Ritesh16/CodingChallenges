using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StacksAndQueues.WallsAndGates
{
    class CodeFile
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
            Queue<int[]> queue = new Queue<int[]>();
            int m = rooms.Length;
            if (m == 0) return;
            int n = rooms[0].Length;

            for (int i = 0; i < rooms.Length; i++)
            {
                for (int j = 0; j < rooms[i].Length; j++)
                {
                    if (rooms[i][j] == GATE)
                        queue.Enqueue(new int[] { i, j });
                }
            }

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                var row = current[0];
                var col = current[1];


                foreach (var direction in DIRECTIONS)
                {
                    var r = row + direction[0];
                    var c = col + direction[1];

                    if (r < 0 || c < 0 || r >= m || c >= n || rooms[r][c] != EMPTY)
                    {
                        continue;
                    }

                    rooms[r][c] = rooms[row][col] + 1;
                    queue.Enqueue(new int[] { r, c });
                }
            }
        }
    }
}
