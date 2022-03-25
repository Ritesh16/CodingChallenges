using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Maths._2160.MinSumof4DigitNumberAfterSplittingDigits
{
    public class CodeFile
    {
        public int MinimumSum(int num)
        {
            var res = new int[4];
            int i = 0;
            while (num > 0)
            {
                res[i++] = num % 10;
                num = num / 10;
            }
            Array.Sort(res);
            return res[0] * 10 + res[1] * 10 + res[2] + res[3];
        }
    }
}
