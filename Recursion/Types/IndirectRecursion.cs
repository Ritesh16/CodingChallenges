using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion.Types
{
    public class IndirectRecursion
    {
        public void FuncA(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(n);
                FuncB(n - 1);
            }
        }

        public void FuncB(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(n);
                FuncA(n / 2);
            }
        }
    }
}
