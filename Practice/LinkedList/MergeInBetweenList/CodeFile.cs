using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.MergeInBetweenList
{
    internal class CodeFile
    {
        public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
        {
            ListNode p1 = list1, p2 = list1;
            while (--a > 0)
            {
                p1 = p1.next;
            }

            while (b-- > 0)
            {
                p2 = p2.next;
            }

            p1.next = list2;
            while (p1.next != null) p1 = p1.next;
            p1.next = p2.next;
            return list1;
        }
    }
}
