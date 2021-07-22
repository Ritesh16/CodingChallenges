using System;
using System.Collections.Generic;
using System.Diagnostics;
using Practice.Arrays.TwoSumII;
//using Practice.StacksAndQueues.NumberofIslands;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            var ob = new CodeFile_TwoPointer();
            var input = new int[] { 2 ,3,4 };

            var result = ob.TwoSum(input, 6);

            foreach (var item in result)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
