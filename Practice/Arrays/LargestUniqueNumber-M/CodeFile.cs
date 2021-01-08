using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Arrays.LargestUniqueNumber_M
{
    public class CodeFile
    {
        public int LargestUniqueNumber(int[] A)
        {
            // Using Hash Table
            int result = -1;
            var dictionary = new SortedDictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (dictionary.ContainsKey(A[i]))
                {
                    var val = dictionary[A[i]] + 1;
                    dictionary[A[i]] = val;
                }
                else
                {
                    dictionary.Add(A[i], 1);
                }
            }

            var res = dictionary.Where(x => x.Value == 1);
            if(res.Count()>0)
            result = res.Max(x => x.Key);

            return result;
        }

        public int LargestUniqueNumber1(int[] A)
        {
            SortedSet<int> ss = new SortedSet<int>();
            HashSet<int> used = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                int val = A[i];
                if (!used.Contains(val))
                {
                    if (ss.Contains(val))
                    {
                        ss.Remove(val);
                        used.Add(val);
                    }
                    else
                    {
                        ss.Add(val);
                    }
                }
            }

            return ss.Count == 0 ? -1 : ss.Max();
        }
    }
}
