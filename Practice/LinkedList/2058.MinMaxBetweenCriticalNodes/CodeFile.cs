﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._2058.MinMaxBetweenCriticalNodes
{
    internal class CodeFile
    {
        public int[] NodesBetweenCriticalPoints(ListNode head)
        {
            var result = new int[2] { -1, -1 };
            var previous = head.val;
            head = head.next;
            var list = new List<int>();
            var count = 1;

            while (head.next != null)
            {
                count++;
                if (previous > head.val && head.next.val > head.val)
                {
                    list.Add(count);
                }

                if (previous < head.val && head.next.val < head.val)
                {
                    list.Add(count);
                }


                previous = head.val;
                head = head.next;

            }


            // Finding high and low
            if (list.Count > 1)
            {
                result[1] = list[list.Count - 1] - list[0];
                result[0] = int.MaxValue;
                for (int i = 1; i < list.Count; i++)
                {
                    result[0] = Math.Min(result[0], Math.Abs(list[i - 1] - list[i]));
                }
            }

            return result;
        }
    }
}
