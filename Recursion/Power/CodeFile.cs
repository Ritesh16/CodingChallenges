using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion.Power
{
    internal class CodeFile
    {
        public int Power(int m, int n)
        {
            if (n <= 1)
            {
                return m;
            }

            return Power(m, n - 1) * m;
        }

        // Less calls to function
        public int Power_Efficient(int m, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            if (n % 2 == 0)
            {
                return Power_Efficient(m * m, n / 2);
            }

            return m * Power_Efficient(m * m, (n - 1) / 2);
        }
    }
}
