using System;
using Practice.Arrays.CountGoodTriplets;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFile ob = new CodeFile();
            var input = new int[] { 10,11,12 };

            var input1 = new int[] { 1, 1, 2, 2, 3 };
            int a = 0;
            int b = 0;
            int c = 1;
            var output = ob.CountGoodTriplets(input1,a,b,c);
            Console.WriteLine(output);
        }
    }
}
