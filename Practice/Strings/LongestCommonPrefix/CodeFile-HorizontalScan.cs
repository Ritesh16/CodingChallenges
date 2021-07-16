using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.LongestCommonPrefix
{
    class CodeFile_HorizontalScan
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1)
            {
                return strs[0];
            }

            var prefix = strs[0];
            var temp = string.Empty;
            var k = 0;
            for (int i = 1; i < strs.Length; i++)
            {
                var input = strs[i];
                if (prefix.Length > input.Length)
                {
                    temp = prefix;
                    prefix = input;
                    input = temp;
                }

                while (k < prefix.Length)
                {
                    if (prefix[k] != input[k])
                    {
                        break;
                    }

                    k++;
                }

                if (k == 0)
                {
                    prefix = "";
                    break;
                }

                prefix = prefix.Substring(0, k);
                k = 0;

            }

            return prefix;
        }
    }
}
