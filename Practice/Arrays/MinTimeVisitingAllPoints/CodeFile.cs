using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.MinTimeVisitingAllPoints
{
    public class CodeFile
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            int time = 0;
            for (int i = 1; i < points.Length; i++)
            {
                var a = points[i - 1];
                var b = points[i];
                int dx = Math.Abs(a[0] - b[0]);
                int dy = Math.Abs(a[1] - b[1]);
                time += Math.Max(dx, dy);
            }
            return time;
        }
    }
}
