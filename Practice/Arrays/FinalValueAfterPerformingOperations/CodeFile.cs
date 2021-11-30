using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.FinalValueAfterPerformingOperations
{
    public class CodeFile
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            var sum = 0;
            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i] == "++X" || operations[i] == "X++")
                {
                    sum++;
                }
                else
                {
                    sum--;
                }
            }

            return sum;
        }
    }
}
