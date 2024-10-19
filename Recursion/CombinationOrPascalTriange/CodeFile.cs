using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion.CombinationOrPascalTriange
{
    internal class CodeFile
    {
        public int PascalTriangle(int n, int r)
        {
            if (r == 0 || n == r) return 1;

            return PascalTriangle(n - 1, r - 1) + PascalTriangle(n - 1, r);
        }
    }
}
