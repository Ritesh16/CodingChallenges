using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion.TowerOfHanoi
{
    internal class CodeFile
    {
        public void TowerOfHanoi(int n, int a, int b, int c)
        {
            if (n > 0)
            {
                TowerOfHanoi(n - 1, a, c, b);
                Console.WriteLine($"Moving disk {n - 1} ({a}, {c})");
                TowerOfHanoi(n - 1, b, a, c);
            }
        }
    }
}
