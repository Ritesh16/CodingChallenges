using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Arrays.IntersectionOfArrays
{
    internal class CodeFile_Fast
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>(nums1);
            HashSet<int> set2 = new HashSet<int>();

            foreach (int num in nums2)
            {
                if (set1.Contains(num))
                {
                    set2.Add(num);
                }
            }

            return set2.ToArray();
        }
    }
}
