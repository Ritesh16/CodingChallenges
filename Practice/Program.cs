using System;
using System.Collections.Generic;
using Practice.Arrays.RemoveElement;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFile ob = new CodeFile();
           
            var array1 = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            int m = 2;

            var output= ob.RemoveElement(array1, m);

            //foreach (var item in output)
            //{
                Console.WriteLine(output);
            //}

        }
    }
}
