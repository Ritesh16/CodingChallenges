using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._148.SortList
{
    public class CodeFile_Practice
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            var mid = FindMid(head);

            var left = SortList(head);
            var right = SortList(mid);

            return Merge(left, right);
        }

        private ListNode Merge(ListNode left, ListNode right)
        {
            if (left == null) return right;
            if (right == null) return left;

            var dummy = new ListNode(int.MinValue);
            var node = dummy;

            while (left != null && right != null)
            {
                if (left.val < right.val)
                {
                    node.next = left;
                    node = left;
                    left = left.next;
                }
                else
                {
                    node.next = right;
                    node = right;
                    right = right.next;
                }
            }

            node.next = (left == null) ? right : left;

            return dummy.next;
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
    }
}
