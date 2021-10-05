using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Practice.Recurssion.Algorithms.DivideAndConquer.MergeSort;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var ob = new CodeFile();
            var input = new int[] { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
            var result = ob.SortArray(input);


            foreach (var item in result)
            {
                Console.WriteLine(item);

            }

            Console.ReadLine();
        }
    }
}
