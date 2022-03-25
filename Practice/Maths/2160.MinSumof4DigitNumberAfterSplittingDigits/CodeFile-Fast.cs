using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Maths._2160.MinSumof4DigitNumberAfterSplittingDigits
{
    public class CodeFile_Fast
    {
        public int MinimumSum(int num)
        {
            int[] na = new int[4];
            na[0] = num % 10;
            num /= 10;
            na[1] = num % 10;
            num /= 10;
            na[2] = num % 10;
            num /= 10;
            na[3] = num;
            Array.Sort<int>(na);

            return (na[0] + na[1]) * 10 + na[2] + na[3];
        }
    }
}
