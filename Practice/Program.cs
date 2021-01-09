using System;
using Practice.Strings.ReverseString;
using Practice.Algorithms.Sorting;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Decimal.Parse("0002654");
            var rrrrr = "ritesh".PadLeft(10, '0');
            CodeFile ob = new CodeFile();
            var input = new int[] { 10,11,12 };

            var input1 = new int[] { 1, 1, 2, 2, 3 };
            int a = 0;
            int b = 0;
            int c = 1;

            var input2 = new int[][]
           {
                new int[] {1, 91},
                new int[] {1,92},
                new int[] { 2,93 },
                new int[] {2, 97 },
                new int[] {1, 60 },
                new int[] {2, 77 },
                new int[] {1, 65 },
                new int[] {1, 87 },
                new int[] {1, 100 },
                new int[] {2, 100 },
                new int[] {2, 76 }
           };

            var input3 = new int[] { 2, 5, 3, 4, 1 };
            var input4 = new int[] { 5, 7, 3, 9, 4, 9, 8, 3, 1 };
            var input5 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var input6 = new char[] { 'h', 'e', 'l', 'l', 'o' , '1' };

            //var output = ob.ReverseString(input6);
            var obj = new InsertionSort();
            var output = obj.Sort(input3);
            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i]);
            }

            //Console.WriteLine(output);
        }
    }
}
