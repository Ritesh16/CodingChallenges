using System;
using System.Collections.Generic;
using System.Diagnostics;
using Practice.Strings.LongestCommonPrefix;
//using Practice.StacksAndQueues.NumberofIslands;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            CodeFile_VerticalScan ob = new CodeFile_VerticalScan();
            var input = new string[] { "ab", "a" };

            var result = ob.LongestCommonPrefix(input);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
