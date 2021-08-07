using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearch.FindKClosestElements
{
    class CodeFile_BinaryIntutive
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            var left = 0;
            var right = arr.Length - k;

            while (left < right)
            {
                var mid = (left + right) / 2;
                if (x - arr[mid] > arr[mid + k] - x)
                {
                    left += 1;
                }
                else
                {
                    right = mid;
                }
            }

            var result = new List<int>();
            for (int i = left; i < left + k; i++)
            {
                result.Add(arr[i]);
            }

            return result;
        }
    }
}
