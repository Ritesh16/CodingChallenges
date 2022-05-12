using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._1460.MakeTwoArraysEqualByReversing
{
    public class CodeFile_Fast
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            var targetNumPerIndex = new Dictionary<int, int>();

            for (int i = 0; i < target.Length; i++)
            {
                if (targetNumPerIndex.ContainsKey(target[i]))
                    targetNumPerIndex[target[i]]++;
                else
                    targetNumPerIndex.Add(target[i], 1);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (!targetNumPerIndex.ContainsKey(arr[i]) || targetNumPerIndex[arr[i]] == 0)
                    return false;

                targetNumPerIndex[arr[i]]--;
            }

            return true;
        }

    }
}
