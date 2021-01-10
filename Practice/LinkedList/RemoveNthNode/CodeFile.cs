using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.RemoveNthNode
{
    public class CodeFile
    {
        public ListNode Load()
        {
            var node = new ListNode(1);
            node.next = new ListNode(2);
            node.next.next = new ListNode(3);
            node.next.next.next = new ListNode(4);
            node.next.next.next.next = new ListNode(5);

            return node;
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var dummy = new ListNode(0);
            dummy.next = head;
            var length = 0;
          
            var first = head;
            while (first != null)
            {
                length++;
                first = first.next;
            }

            length -= n;
            
            first = dummy;

            while (length > 0)
            {
                length--;
                first = first.next;
            }

            first.next = first.next.next;

            return dummy.next;
        }

        // One Pass
        public ListNode RemoveNthFromEndOnePass(ListNode head, int n)
        {
            var dummy = new ListNode(0);
            dummy.next = head;

            var first = dummy;
            var second = dummy;

            for (int i = 1; i <= n + 1; i++)
            {
                first = first.next;
            }

            while (first != null)
            {
                first = first.next;
                second = second.next;
            }

            second.next = second.next.next;

            return dummy.next;
        }
    }

    public class ListNode
    {
        public int Value { get; set; }
        public ListNode next { get; set; }
        public ListNode(int val)
        {
            Value = val;
        }
    }
}
