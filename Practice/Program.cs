using System;
using Practice.Arrays.High5;

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

            var output = ob.HighFive(input2);
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i][0] + " , " + output[i][1]);
            }
        }
    }
}
