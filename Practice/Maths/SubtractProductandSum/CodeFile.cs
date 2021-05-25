using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Maths.SubtractProductandSum
{
    class CodeFile
    {
        public int SubtractProductAndSum(int n)
        {
            int prod = 1;
            int sum = 0;
            int rem = 0;



            while (n > 0)
            {
                rem = n % 10;
                n = n / 10;
                prod = prod * rem;
                sum = sum + rem;

            }

            return prod - sum;
        }
    }
}
