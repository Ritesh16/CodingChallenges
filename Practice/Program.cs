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
            var input = new int[] { 0, 1, 7, 6, 0, 2, 0, 7 };

            ob.DuplicateZeros1(input);

            //foreach (var item in output)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
