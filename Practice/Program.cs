using System;
using Practice.Arrays.SumOfOddLength;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFile ob = new CodeFile();
            var input = new int[] { 10,11,12 };
            var output = ob.SumOddLengthSubarrays(input);
            Console.WriteLine(output);
        }
    }
}
