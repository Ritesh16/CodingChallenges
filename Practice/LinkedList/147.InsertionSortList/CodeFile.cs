using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._147.InsertionSortList
{
    public class CodeFile
    {
        public ListNode InsertionSortList(ListNode head)
        {
            if (head == null || head.next == null) return head;


            var list = head;
            while (list.next != null)
            {
                var next = list.next;
                var start = head;
                while (start != next)
                {
                    if (start.val > next.val)
                    {
                        var temp = start.val;
                        start.val = next.val;
                        next.val = temp;
                    }

                    start = start.next;
                }

                list = list.next;
            }

            return head;
        }
    }
}
