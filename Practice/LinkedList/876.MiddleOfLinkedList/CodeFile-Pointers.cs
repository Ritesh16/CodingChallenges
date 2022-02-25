using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.MiddleOfLinkedList
{
    public class CodeFile_Pointers
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
    }
}
