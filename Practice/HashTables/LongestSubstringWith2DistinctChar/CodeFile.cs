using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.HashTables.LongestSubstringWith2DistinctChar
{
    public class CodeFile
    {
        public int LengthOfLongestSubstringTwoDistinct(string s)
        {
            if (s == null || s.Length == 0)
                return 0;

            var length = s.Length;
            
            // Sliding window
            var left = 0;
            var right = 0;
            var map = new Dictionary<char, int>();
            var maxLength = 0;

            while (right < length)
            {
                map.TryAdd(s[right], 0);
                map[s[right]]++;

                while (left < right && map.Keys.Count > 2)
                {
                    map[s[left]]--;
                    if (map[s[left]] == 0)
                        map.Remove(s[left]);
                    left++;
                }

                maxLength = Math.Max(maxLength, right - left+1);
                right++;
            }

            return maxLength;
        }
    }
}
