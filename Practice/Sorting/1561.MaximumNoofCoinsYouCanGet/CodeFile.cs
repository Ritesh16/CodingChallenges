using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._1561.MaximumNoofCoinsYouCanGet
{
    public class CodeFile
    {
        public int MaxCoins(int[] piles)
        {
            Array.Sort(piles);

            int res = 0;
            for (int i = piles.Length / 3; i < piles.Length; i += 2)
            {
                res += piles[i];
            }

            return res;
        }
    }
}
