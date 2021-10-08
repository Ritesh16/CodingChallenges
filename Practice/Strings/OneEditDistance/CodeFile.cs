using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.OneEditDistance
{
    public class CodeFile
    {
        public bool IsOneEditDistance(string s, string t)
        {
            var m = s.Length;
            var n = t.Length;

            if (m < n)
            {
                return IsOneEditDistance(t, s);
            }

            if (s == t || m - n > 1) return false;

            for (int i = 0; i < n; i++)
            {
                if (s[i] != t[i])
                {
                    int j = m == n ? i + 1 : i;
                    return s.Substring(i + 1) == t.Substring(j);
                }
            }

            return m != n;
        }
    }
}
