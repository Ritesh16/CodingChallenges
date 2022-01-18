using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.DeleteMiddleNode
{
    public class CodeFile
    {
        public ListNode DeleteMiddle(ListNode head)
        {
            if (head == null || head.next == null) return null;

            var slow = head;
            var fast = head;
            ListNode previous = null;

            while (fast.next != null)
            {
                if(fast.next.next == null)
                {
                    previous = slow;
                    slow = slow.next;
                    break;
                }

                previous = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            previous.next = slow.next;

            return head;
        }
    }
}
