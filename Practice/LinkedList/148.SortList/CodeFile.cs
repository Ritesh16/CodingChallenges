using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._148.SortList
{
    // Without extra space
    public class CodeFile
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            var mid = FindMid(head);
            var left = SortList(head);
            var right = SortList(mid);

            return Merge(left, right);
        }

        public ListNode FindMid(ListNode node)
        {
            if (node == null) return node;

            ListNode slowPrevious = null;
            ListNode slow = node;
            ListNode fast = node;

            while (fast != null && fast.next != null)
            {
                slowPrevious = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            slowPrevious.next = null;
            return slow;
        }

        public ListNode Merge(ListNode node1, ListNode node2)
        {
            if (node1 == null) return node2;
            if (node2 == null) return node1;

            var dummy = new ListNode(0);
            var curr = dummy;

            while (node1 != null && node2 != null)
            {
                if (node1.val <= node2.val)
                {
                    curr.next = node1;
                    curr = node1;
                    node1 = node1.next;
                }
                else
                {
                    curr.next = node2;
                    curr = node2;
                    node2 = node2.next;
                }
            }

            curr.next = node1 == null ? node2 : node1;

            return dummy.next;
        }
    }
}
