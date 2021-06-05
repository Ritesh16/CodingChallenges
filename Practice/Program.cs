using System;
using System.Collections.Generic;
using System.Diagnostics;
using Practice.BinaryTree.ConstructFromInorderPostOrder;
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
            var inOrder = new int[] { 9, 3, 15, 20, 7 };
            var postOrder = new int[] { 9, 15, 7, 20, 3 };

            var n = ob.BuildTree(inOrder, postOrder);
            //Console.WriteLine(n);
        }
    }
}
