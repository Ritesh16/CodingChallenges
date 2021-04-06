using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.ReverseLinkedList
{
    public class CodeFile
    {
        public ListNode ReverseList1(ListNode head)
        {
            ListNode prev = null;
            var current = head;
            while (current != null)
            {
                var nextNode = current.next;
                current.next = prev;
                prev = current;
                current = nextNode;
            }

            return prev;
        }

        // Recursive Solution
        //public ListNode ReverseList(ListNode head)
        //{
        //    if (head == null || head.next == null) return head;
        //    var p = ReverseList(head.next);
        //    head.next.next = head;
        //    head.next = null;
        //    return p;
        //}
    }
}
