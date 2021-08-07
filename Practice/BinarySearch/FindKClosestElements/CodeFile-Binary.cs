using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearch.FindKClosestElements
{
    class CodeFile_Binary
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            var result = new List<int>();
            if (arr.Length == k)
            {
                result.AddRange(arr);
                return result;
            }

            var left = 0;
            var right = arr.Length;
            while (left < right)
            {
                var mid = (left + right) / 2;
                if (arr[mid] >= x)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }


            left -= 1;
            right = left + 1;
            while (right - left - 1 < k)
            {
                if (left == -1)
                {
                    right += 1;
                    continue;
                }

                if (right == arr.Length || Math.Abs(arr[left] - x) <= Math.Abs(arr[right] - x))
                {
                    left -= 1;
                }
                else
                {
                    right += 1;
                }
            }

            for (int i = left + 1; i < right; i++)
            {
                result.Add(arr[i]);
            }

            return result;
        }
    }
}
