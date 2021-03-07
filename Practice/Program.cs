using System;
using System.Collections.Generic;
using Practice.Arrays.IntersectionofTwoArrays_II;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFile ob = new CodeFile();
            var input1 = new int[] { 3,1,2 };
            var input2 = new int[] { 1,3 };

            var output = ob.Intersect(input1, input2);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
