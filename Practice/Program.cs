using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Practice.BinarySearch.FindPeakElement;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var ob = new CodeFile_BinarySearch_Iterative();
            var input = new int[] { 1, 2, 3, 1 };

            var result = ob.FindPeakElement(input);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
