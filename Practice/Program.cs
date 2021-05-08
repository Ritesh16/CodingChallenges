using System;
using System.Collections.Generic;
using System.Diagnostics;
using Practice.LinkedList;
using Practice.StacksAndQueues.NumberofIslands;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFile_BFS ob = new CodeFile_BFS();
            char[][] input = new char[4][];
            input[0] = new char[5] { '1', '1', '0', '0', '0' };
            input[1] = new char[5] { '1', '1', '0', '0', '0' };
            input[2] = new char[5] { '0', '0', '1', '0', '0' };
            input[3] = new char[5] { '0', '0', '0', '1', '1' };

            var count = ob.numIslands(input);
            Console.WriteLine(count);
        }
    }
}
