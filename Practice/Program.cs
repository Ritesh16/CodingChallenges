using System;
using Practice.Arrays.MoveZeros;

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

            var input = new int[] { 0, 1, 0, 3, 12 };

            var output = ob.MoveZeroes(input);

            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }

        }
    }
}
