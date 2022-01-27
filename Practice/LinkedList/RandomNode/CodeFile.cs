using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.RandomNode
{
    internal class Solution
    {
        List<int> list = new List<int>();
        Random random = new Random();
        public Solution(ListNode head)
        {
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
        }

        public int GetRandom()
        {
            int num = random.Next(list.Count);
            return list[num];
        }
    }
}
