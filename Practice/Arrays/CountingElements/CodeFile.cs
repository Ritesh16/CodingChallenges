using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.CountingElements
{
    class CodeFile
    {
        public int CountElements(int[] arr)
        {
            var hashSet = new HashSet<int>(arr);
            var count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (hashSet.Contains(arr[i] + 1))
                {
                    count++;
                }
            }


            return count;
        }

        // Faster
        public int CountElements1(int[] arr)
        {
            var hashSet = new HashSet<int>(arr);
            var count = 0;

            foreach (var n in arr)
            {
                if (hashSet.Contains(n + 1))
                {
                    count++;
                }
            }


            return count;
        }
    }
}
