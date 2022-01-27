using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Arrays.IntersectionOfArrays
{
    internal class CodeFile
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            return nums1.ToList().Intersect(nums2.ToList()).ToArray();
        }
    }
}
