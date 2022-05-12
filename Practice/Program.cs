using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Practice.StacksAndQueues.CircularQueue;
using Practice.Sorting._1460.MakeTwoArraysEqualByReversing;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            //var logger = new Logger();
            //Console.WriteLine(logger.ShouldPrintMessage(0, "A"));  // return true, next allowed timestamp for "foo" is 1 + 10 = 11
            //Console.WriteLine(logger.ShouldPrintMessage(0, "B"));  // return true, next allowed timestamp for "bar" is 2 + 10 = 12
            //Console.WriteLine(logger.ShouldPrintMessage(0, "C"));
            //Console.WriteLine(logger.ShouldPrintMessage(0, "A"));// 3 < 11, return false
            //Console.WriteLine(logger.ShouldPrintMessage(0, "B"));  // return true, next allowed timestamp for "bar" is 2 + 10 = 12
            //Console.WriteLine(logger.ShouldPrintMessage(0, "C")); 
            //Console.WriteLine(logger.ShouldPrintMessage(11, "A"));
            //Console.WriteLine(logger.ShouldPrintMessage(11, "B"));
            //Console.WriteLine(logger.ShouldPrintMessage(11, "C"));
            //Console.WriteLine(logger.ShouldPrintMessage(11, "A"));

            //var ob = new MyHashSet();
            //ob.Add(1);
            //ob.Add(2);

            //Console.WriteLine(ob.Contains(2));
            //ob.Remove(2);
            //Console.WriteLine(ob.Contains(2));

            //ob.Add(3);
            //Console.WriteLine(ob.Contains(1));
            //Console.WriteLine(ob.Contains(2));
            //Console.WriteLine(ob.Contains(3));

            //ListNode node = new ListNode(1);
            //node.next = new ListNode(3);
            //node.next.next = new ListNode(4);

            //ListNode node1 = new ListNode(7);
            //node1.next = new ListNode(1);
            //node1.next.next = new ListNode(2);
            //node1.next.next.next = new ListNode(6);

            //node.next.next.next = node1;

            //ListNode node = new ListNode(1);
            //node.next = new ListNode(2);
            //node.next.next = new ListNode(3);

            //ListNode node1 = new ListNode(4);
            ////node1.next = new ListNode(1);
            ////node1.next.next = new ListNode(2);
            ////node1.next.next.next = new ListNode(6);

            //node.next.next.next = node1;


            CodeFile ob = new CodeFile();
            var array = new int[] { 1,1,1,1,1 };
            var array1 = new int[] { 1, 1, 1, 1, 1 };
            var output = ob.CanBeEqual(array, array1);
            Console.WriteLine(output);
            //while (output != null)
            //{
            //    Console.WriteLine(output.val);
            //    output = output.next;   
            //}

        }
    }
}
