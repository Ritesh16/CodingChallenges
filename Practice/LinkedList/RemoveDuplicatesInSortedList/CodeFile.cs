using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.RemoveDuplicatesInSortedList
{
    internal class CodeFile
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var root = head;
            while (head != null)
            {
                var p = head;
                while (head != null && head.val == p.val)
                {
                    head = head.next;
                }

                p.next = head;
            }

            return root;
        }
    }
}
