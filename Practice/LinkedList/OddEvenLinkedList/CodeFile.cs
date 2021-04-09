using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.OddEvenLinkedList
{
    public class CodeFile
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null) return null;

            var oddHead = head;
            var evenHead = head.next;

            var odd = head;
            var even = evenHead;

            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;

                even.next = odd.next;
                even = even.next;
            }

            odd.next = evenHead;

            return oddHead;
        }
    }
}
