using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.RemoveDuplicatesInSortedList
{
    public class CodeFile_Fast
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var curr = head;
            if (head == null)
            {
                return head;
            }

            while (curr.next != null)
            {
                if (curr.val == curr.next.val)
                {
                    curr.next = curr.next.next;
                }
                else
                {
                    curr = curr.next;
                }
            }

            return head;
        }
    }
}
