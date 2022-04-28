using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays._2206.DivideArrayInEqualPair
{
    public class CodeFile
    {
        public bool DivideArray(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (var num in nums)
            {
                if (set.Contains(num))
                {
                    set.Remove(num);
                }
                else
                { 
                    set.Add(num); 
                }
            }


            return set.Count == 0;
        }
    }
}
