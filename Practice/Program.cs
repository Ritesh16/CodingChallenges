using System;
using System.Collections.Generic;
using Practice.Arrays.MergeSortedArray;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFile ob = new CodeFile();
           
            var array1 = new int[] { 1, 2, 4, 0, 0, 0 };
            var array2 = new int[] { 2, 3, 7 };
            int m = 3;
            int n = 3;

            ob.Merge1(array1, m, array2, n);

            //foreach (var item in output)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
