using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Practice.Trie.DesignSearchAutoComplete;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var list=new List<string>();
            list.Add("i love you");
            list.Add("island");
            list.Add("iroman");
            list.Add("i love leetcode");
            var ob = new AutocompleteSystem(list.ToArray(), new int[] { 5,3,2,2 });
            var input = new int[] { 1, 2, 3, 1 };

            var o1 = ob.Input('i');
            var o2 = ob.Input(' ');
            var o3 = ob.Input('a');
            var o4 = ob.Input('#');
            var o5 = ob.Input('i');
            var o6 = ob.Input(' ');
            var o7 = ob.Input('a');

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}

            Console.ReadLine();
        }
    }
}
