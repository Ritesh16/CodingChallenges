using System;
using System.Collections.Generic;
using Practice.Arrays.RotateArray;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFile ob = new CodeFile();

            //int[] arr = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
            //SelectionSort sort = new SelectionSort();
            //var o = sort.Sort(arr);


            //var output = ob.IsPalindromeSecond("Aman, a plan, a canal: Panama");

            //var input = new int[] { 4, 1, 2, 1, 2 };




            //var output = ob.MoveZeroes(input);
            //var output = ob.CountMatches(list, ruleKey, ruleValue);
            //for (int i = 0; i < output.Length; i++)
            //{
            //    Console.WriteLine(output[i]);
            //}

            var input = new int[] { 1,2,3,4,5,6,7 };

            ob.Rotate(input, 3);

            //Console.WriteLine(output);

        }
    }
}
