using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.MiddleOfLinkedList
{
    public class CodeFile
    {
        public ListNode MiddleNode(ListNode head)
        {
            var count = Count(head);

            var mid = (count / 2) + 1;

            for (int i = 1; i < mid; i++)
            {
                head = head.next;
            }

            return head;
        }

        private int Count(ListNode head)
        {
            int count = 0;
            var h = head;

            while (h != null)
            {
                count++;
                h = h.next;
            }

            return count;
        }
    }
}
