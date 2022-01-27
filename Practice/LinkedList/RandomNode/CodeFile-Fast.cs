using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.RandomNode
{
    internal class Solution_Fast
    {
        private ListNode head;
        Random random = new Random();
        public Solution_Fast(ListNode head)
        {
            this.head = head;
        }

        public int GetRandom()
        {
            var candidate = this.head.val;

            var n = 1;

            var cur = head.next;
            n++;

            while (cur != null)
            {
                var randomIndex = random.Next(n);
                if (randomIndex == 0) candidate = cur.val;

                cur = cur.next;
                n++;
            }
            return candidate;
        }
    }
}
