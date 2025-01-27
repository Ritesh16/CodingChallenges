using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.MergeSort.Recursive
{
    public class CodeFile
    {
        public int[] Sort(int[] array)
        {
            var output = MergeSort(array, 0, array.Length - 1);

            return output;
        }

        private int[] MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                var mid = (left + right) / 2;

                var array1 = MergeSort(array, left, mid);
                var array2 = MergeSort(array, mid + 1, right);

                return Merge(array1, array2);
            }

            return new int[] { array[left] };
        }

        private int[] Merge(int[] array1, int[] array2)
        {
            var sortedArray = new int[array1.Length + array2.Length];

            var i = 0;
            var j = 0;
            var index = 0;

            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] < array2[j])
                {
                    sortedArray[index] = array1[i];
                    i++;
                }
                else
                {
                    sortedArray[index] = array2[j];
                    j++;
                }

                index++;
            }

            while (i < array1.Length)
            {
                sortedArray[index] = array1[i];
                i++;
                index++;
            }

            while (j < array2.Length)
            {
                sortedArray[index] = array2[j];
                j++;
                index++;
            }

            return sortedArray;
        }
    }
}
