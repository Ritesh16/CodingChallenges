using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.PlusOne
{
    public class CodeFile
    {
        public int[] PlusOne(int[] digits)
        {
            var length = digits.Length;
            for (int i = length-1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i]++;
                    return digits;
                }
            }

            digits = new int[length + 1];
            digits[0] = 1;
            return digits;
        }
    }
}
