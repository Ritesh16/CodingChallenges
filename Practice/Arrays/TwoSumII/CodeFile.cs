using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.TwoSumII
{
    class CodeFile
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var output = new int[2];
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (dictionary.ContainsKey(numbers[i]))
                {
                    var item = dictionary[numbers[i]];
                    output[0] = item+1;
                    output[1] = i+1;
                    return output;
                }
                else
                {
                    var item = target - numbers[i];
                    dictionary[item] = i;
                }
            }

            return output;
        }
    }
}
