using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.MergeSortedArray
{
    public class CodeFile
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0)
            {
                return;
            }

            if (m == 0)
            {
                Array.Copy(nums2, nums1, nums2.Length);
                return;
            }

            var start = nums1.Length;
            for (int i = nums2.Length - 1; i >= 0; i--)
            {
                nums1[start - 1] = nums2[i];
                start--;
            }

            Array.Sort(nums1);

        }

        // Best solutions
        public void Merge1(int[] nums1, int m, int[] nums2, int n)
        {
            int a1 = m - 1;
            int a2 = n - 1;

            for (int i = m + n - 1; i >= 0; i--)
            {
                if (a2 < 0)
                {
                    break;
                }

                if (a1 >= 0 && nums1[a1] > nums2[a2])
                {
                    nums1[i] = nums1[a1];
                    a1--;
                }
                else
                {
                    nums1[i] = nums2[a2];
                    a2--;
                }
            }
        }
    }
}
