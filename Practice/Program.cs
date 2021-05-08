using System;
using System.Collections.Generic;
using System.Diagnostics;
using Practice.LinkedList;
using Practice.StacksAndQueues.ShortestDistance;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Node ob = new Node();
            ob.Value = 1;

            Node ob1 = new Node();
            ob1.Value = 2;

            Node ob2 = new Node();
            ob2.Value = 3;

            Node ob3 = new Node();
            ob3.Value = 4;

            ob.Nodes = new Node[] { ob1, ob2, ob3 };

            Node ob4 = new Node();
            ob4.Value = 5;

            ob1.Nodes = new Node[] { ob4 };

            Node ob5 = new Node();
            ob5.Value = 6;

            Node ob6 = new Node();
            ob6.Value = 7;


            ob5.Nodes = new Node[] { ob6 };

            ob2.Nodes = new Node[] { ob5 };

            ob3.Nodes = new Node[] { ob6 };

            CodeFile obj = new CodeFile();
            var i = obj.BFS(ob, ob6);

            Console.WriteLine(i);
        }
    }
}
