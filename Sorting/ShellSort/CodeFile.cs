using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.ShellSort
{
    public class CodeFile
    {
        public int[] Sort(int[] arr)
        {
            int n = arr.Length;

            // Start with a big gap, 
            // then reduce the gap
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    int temp = arr[i];

                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                        arr[j] = arr[j - gap];

                    arr[j] = temp;
                }
            }
            return arr;
        }
    }
}
