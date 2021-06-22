using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.SwapNodesLinkedList
{
    class CodeFile_Iterative
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null)
            {
                return head;
            }

            var dummyHead = new ListNode();
            dummyHead.val = -1;
            dummyHead.next = head;

            SwapR(head, dummyHead);
            return dummyHead.next;
        }

        public void SwapR(ListNode node, ListNode previous)
        {

            while (node != null && node.next != null)
            {
                var next = node.next;

                previous.next = next;
                node.next = next.next;
                next.next = node;

                previous = node;
                node = node.next;
            }

        }
    }
}
