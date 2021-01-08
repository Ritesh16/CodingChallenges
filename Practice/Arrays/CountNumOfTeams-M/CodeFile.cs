using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.CountNumOfTeams_M
{
    public class CodeFile
    {
        public int NumTeams(int[] rating)
        {
            // Brute Force

            var result = 0;

            for (int i = 0; i < rating.Length; i++)
            {
                for (int j = i+1; j < rating.Length; j++)
                {
                    if (rating[i] == rating[j]) continue;
                    for (int k = j+1; k < rating.Length; k++)
                    {
                        if (rating[i] < rating[j] && rating[j] < rating[k]) result++;

                        if (rating[i] > rating[j] && rating[j] > rating[k]) result++;
                    }
                }
            }

            return result;
        }
    }
}
