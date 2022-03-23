using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays._1725.RectanglesThatCanFormLargestSquare
{
    public class CodeFile
    {
        public int CountGoodRectangles(int[][] rectangles)
        {
            var maxLen = 0;
            var maxCnt = 0;

            foreach (var rec in rectangles)
            {
                var min = Math.Min(rec[0], rec[1]);
                if (min > maxLen)
                {
                    maxLen = min;
                    maxCnt = 1;
                }
                else if (min == maxLen)
                {
                    maxCnt++;
                }
            }

            return maxCnt;
        }
    }
}
