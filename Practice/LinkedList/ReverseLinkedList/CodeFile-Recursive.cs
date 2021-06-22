using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.ReverseLinkedList
{
    class CodeFile_Recursive
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode newHead = ReverseList(head.next);
            head.next.next = head;
            head.next = null;

            return newHead;
        }
    }
}
