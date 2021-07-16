using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.AddBinary
{
    class CodeFile
    {
        // Bit by Bit Processing
        public string AddBinary(string a, string b)
        {
            var firstLength = a.Length;
            var secondLength = b.Length;
            if (firstLength < secondLength) return AddBinary(b, a);

            int carry = 0;
            var sb = new StringBuilder();
            secondLength = secondLength - 1;
            firstLength = firstLength - 1;
            for (int i = firstLength; i > -1; i--)
            {
                if (a[i] == '1') carry++;
                if (secondLength > -1 && b[secondLength] == '1') carry++;

                if (carry % 2 == 1) sb.Insert(0, "1");
                else sb.Insert(0, "0");

                carry = carry / 2;
                secondLength--;
            }

            if (carry == 1)
            {
                sb.Insert(0, "1");
            }

            return sb.ToString();
        }
    }
}
