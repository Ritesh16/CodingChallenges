using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.ReverseInteger
{
    public class CodeFile
    {
        public int Reverse(int x)
        {
            long res = 0;
            var pop = 0;
            while(x != 0)
            {
                pop = x % 10;
                x = x / 10;
                if (res > int.MaxValue / 10 && res > int.MaxValue && pop > 7) return 0;
                if (res < int.MinValue / 10 && res > int.MinValue && pop < -8) return 0;

                res = (res * 10) + pop;
            }

            return res>int.MaxValue ? 0 : Convert.ToInt32(res);
        }
    }
}
