using System;
using System.Collections.Generic;
using System.Diagnostics;
using Practice.Strings.ReverseWordsinString;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            var ob = new CodeFile_UsingStack();
            var input = new int[] { 2 ,3,4 };

            var result = ob.ReverseWords("  Bob    Loves  Alice   ");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
