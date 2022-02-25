using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._2181.MergeNodesBetweenZeros
{
    public class CodeFile_Fast
    {
        public ListNode MergeNodes(ListNode head)
        {
            int sum = 0;
            var temp = head;
            var res = head;

            while (temp != null)
            {
                if (temp.val != 0)
                {
                    sum += temp.val;
                    temp = temp.next;
                }
                else
                {
                    res.val = sum;
                    res.next = temp.next;

                    temp = res.next;
                    res = res.next;
                    sum = 0;
                }
            }

            return head.next;
        }
    }
}
