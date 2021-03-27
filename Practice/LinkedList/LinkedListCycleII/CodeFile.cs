using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.LinkedListCycleII
{
    public class CodeFile
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            var intersect = GetIntersection(head);
            if (intersect == null)
            {
                return null;
            }

            var ptr1 = head;
            var ptr2 = intersect;
            while (ptr1 != ptr2)
            {
                ptr1 = ptr1.next;
                ptr2 = ptr2.next;
            }

            return ptr1;

        }

        private static ListNode GetIntersection(ListNode head)
        {
            var first = head;
            var second = head;

            while (second != null && second.next != null)
            {
                first = first?.next;
                second = second?.next?.next;

                if (second == first)
                {
                    return second;
                }
            }

            return null;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}
