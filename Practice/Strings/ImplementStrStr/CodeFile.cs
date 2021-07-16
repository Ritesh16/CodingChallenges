using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.ImplementStrStr
{
    class CodeFile
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack.Length <= 0 && needle.Length <= 0) return 0;
            if (haystack.Length > 0 && needle.Length == 0) return 0;
            var hIndex = 0;
            var nIndex = 0;
            var index = -1;
            while (nIndex < needle.Length && hIndex < haystack.Length)
            {
                if (haystack[hIndex] == needle[nIndex] && (hIndex + needle.Length) <= haystack.Length && needle == haystack.Substring(hIndex, needle.Length))
                {
                    return hIndex;
                }

                hIndex++;
            }

            return index;
        }
    }
}
