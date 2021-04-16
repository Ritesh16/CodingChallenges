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
            node.next = new Node(13);

            node.next.random = node;

            node.next.next = new Node(11);

            var node2 = new Node(10);

            node.next.next.next = node2;

            node2.random = node.next.next;


            var data = ob.CopyRandomList(node);
        }
    }
}
