using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.CalculatePower
{
    class CodeFileDynamic
    {
        public double MyPow_OneLiner(double x, int n)
        {
            return Math.Pow(x, n);
        }

        public double MyPow(double x, int n)
        {
            long N = n;
            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }
            double ans = 1;
            double current_product = x;
            for (long i = N; i > 0; i /= 2)
            {
                if ((i % 2) == 1)
                {
                    ans = ans * current_product;
                }
                current_product = current_product * current_product;
            }
            return ans;
        }
    }
}
