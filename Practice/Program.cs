using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Practice.Arrays.ConcatenationofArray;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var ob = new CodeFile();
            var input = new int[] { 1, 3, 2, 1 };

            var result = ob.GetConcatenation(input);

            foreach (var item in result)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
