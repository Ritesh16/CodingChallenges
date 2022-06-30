using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._92.ReverseLinkedListll
{
    public class CodeFile
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (head == null || left == right)
            {
                return head;
            }

            var dummy = new ListNode(int.MinValue);
            dummy.next = head;

            var previousNodeBeforeReverse = dummy;
            ListNode current = head;
            for (int i = 1; i < left; i++)
            {
                previousNodeBeforeReverse = current;
                current = current.next;
            }


            ListNode prevNode = null;

            for (int i = left; i <= right; i++)
            {
                var temp = current.next;
                current.next = prevNode;
                prevNode = current;
                current = temp;
            }

            previousNodeBeforeReverse.next.next = current;
            previousNodeBeforeReverse.next = prevNode;

            return dummy.next;
        }
    }
}
