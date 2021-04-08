using System;
using System.Collections.Generic;
using System.Diagnostics;
using Practice.LinkedList;
using Practice.LinkedList.RemoveElements;

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

            var node = new ListNode(7);
            node.next = new ListNode(7);
            node.next.next = new ListNode(7);
            node.next.next = new ListNode(7);

            var output = ob.RemoveElements(node, 7);
            node = output;
            while (node != null)
            {
                Console.WriteLine(node.val);
                node = node.next;
            }
        }
    }
}
