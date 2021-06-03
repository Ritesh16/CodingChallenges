using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Maths.CalculateMoneyinBank
{
    class CodeFile
    {
        public int TotalMoney(int n)
        {
            var result = 0;
            var start = 1;
            var newWeek = 1;
            for (int i = 1; i <= n; i++)
            {
                result += start;
                start++;

                if (i % 7 == 0)
                {
                    newWeek++;
                    start = newWeek;
                }
            }

            return result;
        }
    }
}
