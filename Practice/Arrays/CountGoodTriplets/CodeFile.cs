using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.CountGoodTriplets
{
    public class CodeFile
    {

        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            // Brute Force
            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                var first = arr[i];
                for (int j = i+1; j < arr.Length; j++)
                {
                    var second = arr[j];
                    if(Math.Abs(first-second) <= a)
                    {
                        for (int k = j + 1; k < arr.Length; k++)
                        {
                            if(( Math.Abs(arr[i]-arr[k]) <= c) && Math.Abs(arr[j]-arr[k]) <= b)
                            {
                                count++;
                            }
                        }
                    }
                }
            }

            return count;
        }

    }
}
