using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.DynamicProgramming.Divisor_Game
{
    internal class CodeFileMyVersion
    {
        // Dooes not work
        public bool DivisorGame(int n)
        {
            var count = 0;
            while (n > 1)
            {
                if (n % 2 == 0 && n != 2)
                {
                    n = n - 2;
                }
                else
                {
                    n = n - 1;
                }

                count++;
            }

            return !(count % 2 == 0);
        }
    }
}
