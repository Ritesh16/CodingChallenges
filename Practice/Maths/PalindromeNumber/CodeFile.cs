using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Maths.PalindromeNumber
{
    public class CodeFile
    {
        public bool IsPalindrome(int x)
        {
            var num = x;
            var sum = 0;
            var remainder = 0;

            while (num > 0)
            {
                remainder = num % 10;
                num = num / 10; ;
                sum = sum * 10 + remainder;
            }

            return sum == x;
        }
    }
}
