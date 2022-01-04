using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.MergeInBetweenList
{
    internal class CodeFile_My
    {
        public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
        {
            var root = list1;
            var count = 0;
            ListNode last = null;

            while (count < a)
            {
                last = list1;
                list1 = list1.next;
                count++;
            }

            while (list2 != null)
            {
                last.next = new ListNode(list2.val);
                last = last.next;
                list2 = list2.next;
            }

            while (list1 != null)
            {
                if (count <= b)
                {
                    list1 = list1.next;
                    count++;
                    continue;
                }

                last.next = new ListNode(list1.val);
                last = last.next;
                list1 = list1.next;
            }

            return root;
        }
    }
}
