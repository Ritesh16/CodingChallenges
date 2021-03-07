using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.IntersectionofTwoArrays_II
{
    public class CodeFile
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var i = 0;
            var j = 0;

            Array.Sort(nums1);
            Array.Sort(nums2);
            var output = new List<int>();
            while(i<nums1.Length && j< nums2.Length)
            {
                if(nums1[i] < nums2[j])
                {
                    i++;
                }
                else if(nums1[i] > nums2[j])
                {
                    j++;
                }
                else
                {
                    output.Add(nums1[i]);
                    i++;
                    j++;
                }
            }
            
            return output.ToArray();
        }
    }
}
