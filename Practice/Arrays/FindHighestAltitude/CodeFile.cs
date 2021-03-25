using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.FindHighestAltitude
{
    public class CodeFile
    {
        public int LargestAltitude(int[] gain)
        {
            int max = 0;
            int maxAlt = 0;

            for (int i = 0; i < gain.Length; i++)
            {
                maxAlt += gain[i];
                if (max < maxAlt)
                {
                    max = maxAlt;
                }
            }

            return max;
        }
    }
}
