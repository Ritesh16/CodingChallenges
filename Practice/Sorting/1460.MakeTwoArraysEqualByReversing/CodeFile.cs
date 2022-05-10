using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._1460.MakeTwoArraysEqualByReversing
{
    public class CodeFile
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            Array.Sort(target);
            Array.Sort(arr);

            var i = 0;

            while (i < arr.Length)
            {
                if (target[i] != arr[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
