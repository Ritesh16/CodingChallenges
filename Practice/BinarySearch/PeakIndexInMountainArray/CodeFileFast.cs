using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearch.PeakIndexInMountainArray
{
    internal class CodeFileFast
    {
        public int PeakIndexInMountainArray(int[] arr)
        {
            var left = 0;
            var right = arr.Length - 1;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (arr[mid] > arr[mid + 1] && arr[mid] > arr[mid - 1])
                {
                    return mid;
                }
                else if (arr[mid] > arr[mid + 1])
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }

            }


            return -1;
        }
    }
}
