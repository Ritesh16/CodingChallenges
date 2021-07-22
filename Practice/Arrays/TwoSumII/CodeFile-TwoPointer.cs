using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.TwoSumII
{
    class CodeFile_TwoPointer
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var output = new int[2];
            var frontPointer = 0;
            var backPointer = numbers.Length - 1;
            var sum = 0;
            while (frontPointer < backPointer)
            {
                sum = numbers[frontPointer] + numbers[backPointer];
                if (sum == target)
                {
                    output[0] = frontPointer + 1;
                    output[1] = backPointer + 1;
                    return output;
                }
                else if (sum > target)
                {
                    backPointer--;
                }
                else
                {
                    frontPointer++;
                }
            }

            return output;
        }
    }
}
