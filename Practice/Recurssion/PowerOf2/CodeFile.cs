using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.PowerOf2
{
    class CodeFile
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n == 0) return false;
            while (n % 2 == 0)
            {
                n = n / 2;
            }

            return n == 1;
        }
    }
}
