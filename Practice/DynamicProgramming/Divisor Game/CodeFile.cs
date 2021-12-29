using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.DynamicProgramming.Divisor_Game
{
    internal class CodeFile
    {
        public bool DivisorGame(int n)
        {
            if (n % 2 == 0)
                return true;

            return false;
        }
    }
}
