using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.KthSymbolinGrammar
{
    class CodeFile_Dynamic
    {
        public int KthGrammar(int N, int K)
        {
            if (N == 1)
            {
                return 0;
            }

            var parent = KthGrammar(N - 1, (K / 2) + (K % 2));
            var isOdd = !(K % 2 == 0);

            if (parent == 1)
            {
                return isOdd ? 1 : 0;
            }
            else
            {
                return isOdd ? 0 : 1;
            }

        }
    }
}
