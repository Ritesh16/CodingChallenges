using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._2074.ReverseNodesinEvenLengthGroups
{
    // Less Memory
    public class CodeFile_Fast
    {
        public ListNode ReverseEvenLengthGroups(ListNode head)
        {
            if (head == null || head.next == null) return head;

            var group = 1;
            var count = 0;
            var result = new ListNode(int.MinValue);
            var current = result;
            while (head != null)
            {
                var node = new ListNode(int.MinValue);
                var c = node;
                while (count < group && head != null)
                {
                    c.next = new ListNode(head.val);
                    c = c.next;
                    head = head.next;
                    count++;
                }

                if (count % 2 == 0)
                {
                    node.next = ReverseList(node.next);
                }

                current.next = node.next;
                while (current.next != null)
                {
                    current = current.next;
                }

                group++;
                count = 0;
            }

            return result.next;
        }
        public ListNode ReverseList(ListNode head)
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
    }
}
