using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.LongestCommonPrefix
{
    class CodeFile_BinarySearch
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length <= 0)
            {
                return "";
            }

            var minLength = int.MaxValue;
            foreach (var item in strs)
            {
                minLength = Math.Min(item.Length, minLength);
            }



            var start = 1;
            var end = minLength;

            while (start <= end)
            {
                var mid = (start + end) / 2;
                if (CommonPrefixFound(strs, mid))
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return strs[0].Substring(0, (start + end) / 2);
        }

        private bool CommonPrefixFound(string[] strs, int mid)
        {
            var str1 = strs[0].Substring(0, mid);
            for (int i = 1; i < strs.Length; i++)
                if (!strs[i].StartsWith(str1))
                    return false;
            return true;
        }
    }
}
