using System;
using System.Collections.Generic;
using Practice.Arrays.DuplicateZeros;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFile ob = new CodeFile();
            var input = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };

            ob.DuplicateZeros(input);

            //foreach (var item in output)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
