using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.ValidMountainArray
{
    public class CodeFile
    {
        public bool ValidMountainArray(int[] arr)
        {
            var increasing = 0;
            var decreasing = 0;

            if (arr.Length < 3) return false;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    if (decreasing == 1) return false;

                    increasing = 1;
                }
                else if (arr[i - 1] > arr[i])
                {
                    decreasing = 1;
                }
                else
                {
                    return false;
                }
            }

            return increasing == decreasing && increasing == 1;
        }
    }
}
