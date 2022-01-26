using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearch.PeakIndexInMountainArray
{
    internal class CodeFile
    {
        public int PeakIndexInMountainArray(int[] arr)
        {
            var result = -1;
            var val = arr[0];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (val < arr[i + 1])
                {
                    val = arr[i + 1];
                    result = i + 1;
                }
            }


            return result;
        }
    }
}
