using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.PalindromeLinkedList
{
    public class CodeFile
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null) return true;

            var p1 = head;
            var endOfFirstHalf = EndOfFirstHalf(head);

            var p2 = ReverseLinkedList(endOfFirstHalf.next);
            while (p2 != null)
            {
                if (p1.val != p2.val)
                {
                    return false;
                }

                p1 = p1.next;
                p2 = p2.next;
            }

            return true;
        }

        private ListNode EndOfFirstHalf(ListNode head)
        {
            var fast = head;
            var slow = head;

            while (fast.next != null && fast.next.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            return slow;
        }

        private ListNode ReverseLinkedList(ListNode head)
        {
            ListNode previous = null;
            ListNode current = head;

            while (current != null)
            {
                var nextNode = current.next;
                current.next = previous;
                previous = current;
                current = nextNode;
            }

            return previous;
        }
    }
}
