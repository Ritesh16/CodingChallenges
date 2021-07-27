using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Practice.Arrays.TruncateSentence;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var ob = new CodeFile_InBuilt();
            var input = new int[] { 0, 2, 1, 5, 3, 4 };

            var result = ob.TruncateSentence("chopper is not a tanuki", 5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
