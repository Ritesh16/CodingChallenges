using System;
using System.Collections.Generic;
using System.Diagnostics;
using Practice.LinkedList.DesignLinkedList;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //CodeFile ob = new CodeFile();

            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < 10000; i++)
            //{


            //}

            //sw.Stop();

            var list = new MyLinkedList();
            list.AddAtHead(4);
            var o1 = list.Get(1);
            list.AddAtHead(1);
            list.AddAtHead(5);
            list.DeleteAtIndex(3);
            
            list.AddAtHead(7);
            list.AddAtHead(5);

            var o2 = list.Get(3);
            var o3 = list.Get(3);
            var o4 = list.Get(3);
            list.AddAtHead(1);

            list.DeleteAtIndex(4);

            list.Get(5);

            list.DeleteAtIndex(6);
            list.DeleteAtIndex(4);

            //list.DeleteAtIndex(2);
            //list.DeleteAtIndex(10);
            //list.DeleteAtIndex(0);
            //list.DeleteAtIndex(1);
            //list.DeleteAtIndex(0);


            //            Console.WriteLine(output);

            //Console.WriteLine("Milliseconds :" + sw.ElapsedMilliseconds);
        }
    }
}
