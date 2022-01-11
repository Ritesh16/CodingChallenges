using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.SwappingLinkedList
{
    internal class CodeFile
    {
        public ListNode SwapNodes(ListNode head, int k)
        {
            var current = head;
            ListNode start = null, trail = null;
            var i = 1;

            while (current != null)
            {
                if (trail != null)
                {
                    trail = trail.next;
                }

                if (i == k)
                {
                    start = current;
                    trail = head;
                }

                current = current.next;
                i++;
            }

            var temp = start.val;
            start.val = trail.val;
            trail.val = temp;

            return head;
        }
    }
}
