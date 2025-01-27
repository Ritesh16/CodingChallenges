using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.MergeSort.Iterative
{
    public class CodeFile
    {
        public void Sort(int[] arr)
        {
            int n = arr.Length;
            int[] temp = new int[n];

            for (int currentSize = 1; currentSize < n; currentSize *= 2)
            {
                for (int leftStart = 0; leftStart < n - 1; leftStart += 2 * currentSize)
                {
                    int mid = Math.Min(leftStart + currentSize - 1, n - 1);
                    int rightEnd = Math.Min(leftStart + 2 * currentSize - 1, n - 1);
                    Merge(arr, temp, leftStart, mid, rightEnd);
                }
            }
        }

        public void Merge(int[] arr, int[] temp, int left, int mid, int right)
        {
            int i = left, j = mid + 1, k = left;

            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];
                }
            }

            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }

            while (j <= right)
            {
                temp[k++] = arr[j++];
            }

            for (i = left; i <= right; i++)
            {
                arr[i] = temp[i];
            }
        }
    }
}
