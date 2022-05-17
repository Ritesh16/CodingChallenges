using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays._1748.SumofUniqueElements
{
    public class CodeFile
    {
        public int SumOfUnique(int[] nums)
        {
            var result = 0;
            var hashSet = new HashSet<int>();

            foreach (var item in nums)
            {
                if (!hashSet.Contains(item))
                {
                    result += item;
                }
                else if(result > 0)
                {
                    result -= item;
                }

                hashSet.Add(item);
            }

            return result;
        }
    }
}
