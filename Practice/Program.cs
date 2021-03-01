using System;
using System.Collections.Generic;
using Practice.Arrays.CountItemsMatchingRule;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFile ob = new CodeFile();

            //int[] arr = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
            //SelectionSort sort = new SelectionSort();
            //var o = sort.Sort(arr);


            //var output = ob.IsPalindromeSecond("Aman, a plan, a canal: Panama");

            //var input = new int[] { 4, 1, 2, 1, 2 };

            var list1 = new List<string>();
            list1.Add("phone");
            list1.Add("blue");
            list1.Add("pixel");

            var list2 = new List<string>();
            list2.Add("computer");
            list2.Add("silver");
            list2.Add("phone");

            var list3 = new List<string>();
            list3.Add("phone");
            list3.Add("gold");
            list3.Add("iphone");

            var list = new List<IList<string>>();
            list.Add(list1);
            list.Add(list2);
            list.Add(list3);

            string ruleKey = "type";
            string ruleValue = "phone";


            //var output = ob.MoveZeroes(input);
            var output = ob.CountMatches(list, ruleKey, ruleValue);
            //for (int i = 0; i < output.Length; i++)
            //{
            //    Console.WriteLine(output[i]);
            //}

            Console.WriteLine(output);

        }
    }
}
