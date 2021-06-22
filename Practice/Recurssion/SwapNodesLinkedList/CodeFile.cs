using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.SwapNodesLinkedList
{
    class CodeFile
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

            Swap(head, dummyHead);
            return dummyHead.next;
        }

        public void Swap(ListNode node, ListNode previous)
        {
            if (node == null || node.next == null)
            {
                return;
            }

            var next = node.next;

            previous.next = next;
            node.next = next.next;
            next.next = node;

            previous = node;

            Swap(node.next, previous);
        }
    }
}
