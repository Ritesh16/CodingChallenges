using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.ImplementStrStr
{
    class CodeFileClean
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
                return 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (i + needle.Length - 1 < haystack.Length)
                {
                    if (needle.Equals(haystack.Substring(i, needle.Length)))
                        return i;
                }
            }

            return -1;
        }
    }
}
