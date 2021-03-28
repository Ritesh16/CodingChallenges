using System;
using System.Collections.Generic;
using System.Diagnostics;
using Practice.LinkedList;
using Practice.LinkedList.LinkedListCycle;

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
            var d  = new ListNode(3);

            node.next.next = d;

            //d.next = node.next;

            var output = ob.HasCycle(node);
            Console.WriteLine(output);
        }
    }
}
