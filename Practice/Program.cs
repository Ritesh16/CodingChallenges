using System;
using System.Collections.Generic;
using System.Diagnostics;
using Practice.Arrays.ThirdMaximumNumber;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFile ob = new CodeFile();

            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < 10000; i++)
            //{


            //}

            //sw.Stop();

            var array2 = new int[] { 1,1,2 };


            var output = ob.ThirdMax(array2);
            Console.WriteLine(output);

            //Console.WriteLine("Milliseconds :" + sw.ElapsedMilliseconds);
        }
    }
}
