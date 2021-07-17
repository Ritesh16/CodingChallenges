using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.LongestCommonPrefix
{
    class CodeFile_VerticalScan
    {
        public string LongestCommonPrefix(string[] strs)
        {
            for (int i = 0; i < strs[0].Length; i++)
            {
                char val1 = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i == strs[j].Length || val1 != strs[j][i])
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }

            return strs[0];
        }
    }
}