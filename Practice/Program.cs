using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Practice.Trie.AddAndSearchWord;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var ob = new WordDictionary();

            ob.AddWord("a");
            ob.AddWord("a");

            var res1 = ob.Search(".");
            var res2 = ob.Search("a");
            var res3 = ob.Search(".a");
            var res4 = ob.Search("a.");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}

            Console.ReadLine();
        }
    }
}
