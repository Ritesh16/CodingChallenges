using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Maths.ArmstrongNumber
{
    class CodeFile
    {
        public bool IsArmstrong(int n)
        {
            int length = 0;

            // Get the number of digits in integer `N`.
            int tempN = n;

            // Get the length of the integer `N`
            while (tempN != 0)
            {
                length++;
                tempN /= 10;
            }

            // Return true if Sum of k'th power of digits equals original number.
            return getSumOfKthPowerOfDigits(n, length) == n;
        }
        public int getSumOfKthPowerOfDigits(int N, int k)
        {
            // `result` stores the result of sum of k'th power of each digit.
            int result = 0;

            // Run until N is not 0
            while (N != 0)
            {
                // Modulo 10 gives us the last digit
                // Add digit ^ k to the result
                result += (int)Math.Pow(N % 10, k);

                // Remove the last digit.
                N /= 10;
            }
            return result;
        }
    }
}
