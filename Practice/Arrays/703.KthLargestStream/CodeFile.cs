using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Arrays._703.KthLargestStream
{
    public class KthLargest
    {
        private int kth;
        private SortedDictionary<int, int> minHeap;
        private int actualSize;

        public KthLargest(int k, int[] nums)
        {
            kth = k;
            minHeap = new SortedDictionary<int, int>();
            foreach (var n in nums)
                Add(n);
        }

        public int Add(int val)
        {
            if (minHeap.ContainsKey(val))
            {
                minHeap[val]++;
            }
            else
            {
                minHeap.Add(val, 1);
            }

            actualSize++;

            if (actualSize > kth)
            {
                var min = minHeap.First();
                if (min.Value == 1)
                {
                    minHeap.Remove(min.Key);
                }
                else
                {
                    minHeap[min.Key]--;
                }

                actualSize--;
            }

            return minHeap.First().Key;
        }
    }
}
