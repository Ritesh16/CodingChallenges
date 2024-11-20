using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion.Types
{
    public class HeadRecursion
    {
        public void Process(int n)
        {
            if (n > 0)
            {
                Process(n - 1);
                Console.WriteLine(n);
            }
        }
    }
}
