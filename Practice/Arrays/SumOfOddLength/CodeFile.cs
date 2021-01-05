using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.SumOfOddLength
{
    public class CodeFile
    {
        public int SumOddLengthSubarrays(int[] arr)
        {
            // Brute force
            var result = 0;
            var oddSum = 0;
            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
                for (int j = i; j < arr.Length; j++)
                {
                    oddSum += arr[j];
                    count++;
                    if(count>1 && count%2!=0)
                    {
                        result += oddSum;
                    }
                }

                count = 0;
                oddSum = 0;
            }

            return result;
        }
    }
}
