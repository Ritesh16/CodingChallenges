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
            list.AddAtHead(1);
            list.AddAtTail(3);
            list.AddAtIndex(1,2);

            var id= list.Get(1);

            list.DeleteAtIndex(0);

            var g = list.Get(0);
        }
    }
}
