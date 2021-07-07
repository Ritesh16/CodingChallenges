using System;
using System.Collections.Generic;
using System.Diagnostics;
using Practice.Recurssion.UniqueBinarySearchTrees;
//using Practice.StacksAndQueues.NumberofIslands;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //CodeFile_UnionFind ob = new CodeFile_UnionFind();
            //char[][] input = new char[4][];
            //input[0] = new char[3] { '1', '1', '1' };
            //input[1] = new char[3] { '1', '1', '0' };
            //input[2] = new char[3] { '1', '1', '0' };
            //input[3] = new char[3] { '1', '0', '0' };

            //var count = ob.NumIslands(input);
            //Console.WriteLine(count);

            //ListNode node = new ListNode(1);
            //node.next = new ListNode(2);
            //node.next.next = new ListNode(3);

            //CodeFile_Pointers ob = new CodeFile_Pointers();
            //var n = ob.MiddleNode(node);
            CodeFile ob = new CodeFile();
            var result = ob.NumTrees(5);

            CodeFile_Recurssion obr = new CodeFile_Recurssion();
            var r1 = obr.NumTrees(5);
            if (r1 == result)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine($"First:{result}, Second:{r1}");
            }

            Console.ReadLine();
            //Console.WriteLine(n);
        }
    }
}
