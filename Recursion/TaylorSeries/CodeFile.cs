using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion.TaylorSeries
{
    internal class CodeFile
    {
        double power = 1;
        double factorial = 1;
        double s = 0;
        public double TaylorSeries(int x, int n)
        {
            double result = 0;

            if (n == 0)
            {
                return 1;
            }

            result = TaylorSeries(x, n - 1);
            power = x * power;
            factorial = factorial * n;

            return result + power / factorial;
        }

        public double TaylorSeries_Horner(int x, int n)
        {
            if (n == 0)
            {
                return s;
            }

            s = 1 + x * s / n;


            return TaylorSeries_Horner(x, n - 1);
        }
    }
}
