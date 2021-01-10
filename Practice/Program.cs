using System;
using Practice.Algorithms.Sorting;

using Practice.LinkedList.RemoveNthNode;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFile ob = new CodeFile();
            var obj = new InsertionSort();

            
            var node = ob.Load();

            node = ob.RemoveNthFromEndOnePass(node, 5);

            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.next;
            }

            //for (int i = 0; i < output.Length; i++)
            //{
            //    Console.WriteLine(output[i]);
            //}

            //Console.WriteLine(output);
        }
    }
}
