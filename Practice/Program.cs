using System;
using System.Collections.Generic;
using System.Diagnostics;
using Practice.LinkedList;
using Practice.LinkedList.CopyListwithRandomPointer;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFile ob = new CodeFile();
            Node node = new Node(7);

            Node node2 = new Node(13);
            node.next = node2;

            Node node3 = new Node(11);
            node2.next = node3;
           

            Node node4 = new Node(10);
            node3.next = node4;
            node4.random = node3;

            Node node5 = new Node(1);
            node4.next = node5;
            node5.random = node;

            node3.random = node5;

            var output = ob.CopyRandomList(node);

            while (output != null)
            {
                Console.WriteLine(output.val);
                output = output.next;
            }

          
        }
    }
}
