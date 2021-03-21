using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Arrays.ThirdMaximumNumber
{
    public class CodeFile
    {
        public int ThirdMax(int[] nums)
        {
            SortedSet<int> list = new SortedSet<int>();
            var result = 0;
            var index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                list.Add(nums[i]);
            }

            if (list.Count < 3)
            {
                return list.Last();
            }

            foreach (var item in list)
            {
                if (index == list.Count - 3)
                {
                    result = item;
                    break;
                }

                index++;
            }

            return result;
        }
        public int ThirdMax1(int[] nums)
        {
            var result = 0;
            var array = new int[3];
            var smallest = -1;
            

            var hashset = new HashSet<int>();
            for (int j = 0; j < nums.Length; j++)
            {
                hashset.Add(nums[j]);
            }

         
            if(hashset.Count <= 2)
            {
                var first = hashset.First();
                hashset.Remove(first);
                if (hashset.Count == 1)
                {
                    var second = hashset.First();
                    return first < second ? second : first;
                }

                return first;
            }

            var i = 0;
            foreach (var item in hashset)
            {
                if (i > 2)
                {
                    smallest = array[0] < array[1] ? 0 : 1;
                    smallest = array[smallest] < array[2] ? smallest : 2;
                    if (array[smallest] < item)
                        array[smallest] = item;
                }
                else
                {
                    array[i] = item;
                }

                i++;
            }

            result = array[0] < array[1] ? array[0] : array[1];

            result = result < array[2] ? result : array[2];

            return result;
        }
    }
}
