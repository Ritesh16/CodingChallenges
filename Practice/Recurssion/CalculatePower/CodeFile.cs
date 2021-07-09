using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.CalculatePower
{
    class CodeFile
    {
        public double MyPow(double x, int n)
        {
            long p = (long)n;


            if (p < 0)
            {
                x = 1 / x;
                p = -p;
            }

            double result = 1;

            while (p > 0)
            {
                if (p % 2 == 1)
                {
                    result = result * x;
                }

                x = x * x;
                p = p / 2;
            }


            return result;
        }
    }
}
