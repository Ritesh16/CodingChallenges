using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.AddTwoNumbers
{
    public class CodeFile
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var prehead = new ListNode(0);
            //prehead.next = l1;

            var p1 = l1;
            var p2 = l2;
            var carry = 0;
            var curr = prehead;

            while (p1 != null || p2 != null)
            {
                var x = p1 != null ? p1.val : 0;
                var y = p2 != null ? p2.val : 0;

                var sum = x + y + carry;

                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p1 != null) p1 = p1.next;

                if (p2 != null) p2 = p2.next;
            }

            if (carry != 0)
            {
                curr.next = new ListNode(carry);
            }

            return prehead.next;
        }
    }
}
