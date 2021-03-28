using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.LinkedListCycle
{
    public class CodeFile
    {
        public bool HasCycle(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if(slow == fast)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
