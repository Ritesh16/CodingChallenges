using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Practice.LinkedList.DesignHashSet;

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

            var ob = new MyHashSet();
            ob.Add(1);
            ob.Add(2);

            Console.WriteLine(ob.Contains(2));
            ob.Remove(2);
            Console.WriteLine(ob.Contains(2));

            ob.Add(3);
            Console.WriteLine(ob.Contains(1));
            Console.WriteLine(ob.Contains(2));
            Console.WriteLine(ob.Contains(3));


            Console.ReadLine();
        }
    }
}
