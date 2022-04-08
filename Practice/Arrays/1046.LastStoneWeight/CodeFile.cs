using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Arrays._1046.LastStoneWeight
{
    public class CodeFile
    {
        public int LastStoneWeight(int[] stones)
        {
            var list = new List<int>(stones);

            return FindLastStone(list);
        }

        private int FindLastStone(List<int> list)
        {
            if (list.Count == 0)
                return 0;
            else if (list.Count == 1)
                return list[0];
            else
            {
                var num1 = list.Max();
                list.Remove(num1);

                var num2 = list.Max();
                list.Remove(num2);

                if (num1 > num2)
                {
                    var dif = Math.Abs(num2 - num1);
                    list.Add(dif);
                }

                return FindLastStone(list);
            }


        }
    }
}
