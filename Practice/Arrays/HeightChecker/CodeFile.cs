using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.HeightChecker
{
    public class CodeFile
    {
        public int HeightChecker(int[] heights)
        {
            var result = 0;
            var sortedHeights = new int[heights.Length];

            for (int i = 0; i < heights.Length; i++)
            {
                sortedHeights[i] = heights[i];
            }
           
            Array.Sort(sortedHeights);

            for (int i = 0; i < heights.Length; i++)
            {
                if(heights[i] != sortedHeights[i])
                {
                    result++;
                }
            }

            return result;
        }
    }
}
