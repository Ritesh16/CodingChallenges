using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion.SumofNNumbers
{
    internal class CodeFile
    {
        public int Sum(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            return Sum(n - 1) + n;
        }

        public int Sum_Iterative(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}
