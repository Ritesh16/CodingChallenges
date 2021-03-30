using System;
using System.Collections.Generic;
using System.Diagnostics;
using Practice.LinkedList;
using Practice.LinkedList.Intersectionof2LinkedList;

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

            var node = new ListNode(1);
            node.next = new ListNode(2);
            node.next.next = new ListNode(3);

            var intersection = new ListNode(4);
            node.next.next.next = intersection;

            var node2 = new ListNode(1);
            node2.next = new ListNode(2);
            node2.next = intersection;

            intersection.next = new ListNode(5);
            intersection.next.next = new ListNode(6);
            //d.next = node.next;

            var output = ob.getIntersectionNode(node, node2);
            Console.WriteLine(output.val);
        }
    }
}
