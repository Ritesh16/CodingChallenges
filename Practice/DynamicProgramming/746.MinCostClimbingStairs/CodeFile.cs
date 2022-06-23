using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.DynamicProgramming._746.MinCostClimbingStairs
{
    public class CodeFile
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            var prevPrev = cost[0];
            var prev = cost[1];

            for (int i = 2; i < cost.Length; i++)
            {
                var currCost = Math.Min(prev, prevPrev) + cost[i];
                prevPrev = prev;
                prev = currCost;
            }

            return Math.Min(prev, prevPrev);
        }
    }
}
