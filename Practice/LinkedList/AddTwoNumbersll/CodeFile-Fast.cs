using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.AddTwoNumbersll
{
    internal class CodeFile_Fast
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            l1 = Reverse(l1);
            l2 = Reverse(l2);
            int carry = 0;
            ListNode head = null;
            while (l1 != null || l2 != null)
            {
                int x = (l1 == null) ? 0 : l1.val;
                int y = (l2 == null) ? 0 : l2.val;

                int sum = x + y + carry;
                carry = sum / 10;


                ListNode curr = new ListNode(sum % 10);
                curr.next = head;
                head = curr;

                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;

            }

            if (carry > 0)
            {
                ListNode curr = new ListNode(carry);
                curr.next = head;
                head = curr;
            }
            return head;
        }


        private static ListNode Reverse(ListNode node)
        {
            if (node == null)
                return null;
            ListNode curr = null;
            while (node != null)
            {
                var temp = node.next;
                node.next = curr;
                curr = node;
                node = temp;
            }
            return curr;
        }
    }
}
