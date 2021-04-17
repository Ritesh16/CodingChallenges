using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.RotateList
{
    public class CodeFile
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
            {
                return null;
            }

            if(head.next == null)
            {
                return head;
            }

            var count = 0;
            ListNode tail = head;
            while (tail != null && tail.next != null)
            {
                tail = tail.next;
                count++;
            }

            count++;
            tail.next = head;

            var num = count - k % count;
            num = num - 1;

            var start = head;
            for (int i = 0; i < num; i++)
            {
                start = start.next;
            }

            head = start.next;
            start.next = null;
            return head;
        }
    }
}
