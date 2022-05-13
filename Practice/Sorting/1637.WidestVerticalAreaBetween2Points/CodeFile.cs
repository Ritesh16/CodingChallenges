using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._1637.WidestVerticalAreaBetween2Points
{
    public class CodeFile
    {
        public int MaxWidthOfVerticalArea(int[][] points)
        {
            List<int> xPoints = new List<int>();

            foreach (var item in points)
            {
                xPoints.Add(item[0]);
            }

            xPoints.Sort();
            int max = 0;

            for (int i = 1; i < xPoints.Count; i++)
            {
                max = Math.Max(max, xPoints[i] - xPoints[i - 1]);
            }

            return max;
        }
    }
}
