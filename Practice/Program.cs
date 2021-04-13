using System;
using System.Collections.Generic;
using System.Diagnostics;
using Practice.LinkedList;
using Practice.LinkedList.DoublyLinkedList;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //CodeFile ob = new CodeFile();
            MyLinkedList list = new MyLinkedList();
            list.addAtIndex(0, 1);
            list.addAtHead(1);
            list.addAtTail(3);
            list.addAtIndex(1,2);

            var i = list.Get(1);
            list.DeleteAtIndex(0);

            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < 10000; i++)
            //{


            //}

            //sw.Stop();

            //var node = new ListNode(7);
            //node.next = new ListNode(7);
            //node.next.next = new ListNode(7);
            //node.next.next = new ListNode(7);


            //var output = ob.RemoveElements(node, 7);
            //node = output;
            //while (node != null)
            //{
            //    Console.WriteLine(node.val);
            //    node = node.next;
            //}
        }
    }
}
