using System;
using System.Collections.Generic;
using Practice.Arrays.ValidMountainArray;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFile ob = new CodeFile();

            var array1 = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            int m = 2;
            var array2 = new int[] { 1, 1, 1, 1, 1, 1, 1, 2, 1};


            var output = ob.ValidMountainArray(array2);

            //foreach (var item in output)
            //{
            Console.WriteLine(output);
            //}

        }
    }
}
