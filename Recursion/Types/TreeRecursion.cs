using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion.Types
{
    public class TreeRecursion
    {
        public void Process(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(n);
                Process(n - 1);
                Process(n - 1);
            }
        }
    }
}
