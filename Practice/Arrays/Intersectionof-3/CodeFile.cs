using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.Intersectionof_3
{
    public class CodeFile
    {
        public IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3)
        {
            int p1 = 0, p2 = 0, p3 = 0;
            var output = new List<int>();

            while (p1 < arr1.Length && p2 < arr2.Length && p3 < arr3.Length)
            {
                if (arr1[p1] == arr2[p2] && arr2[p2] == arr3[p3])
                {
                    output.Add(arr1[p1]);
                    p1++;
                    p2++;
                    p3++;
                }
                else if (arr1[p1] < arr2[p2])
                {
                    p1++;
                }
                else if (arr2[p2] < arr3[p3])
                {
                    p2++;
                }
                else
                {
                    p3++;
                }
            }

            return output;
        }
    }
}
