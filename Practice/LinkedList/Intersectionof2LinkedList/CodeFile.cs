using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.Intersectionof2LinkedList
{
    public class CodeFile
    {
        public ListNode getIntersectionNode1(ListNode headA, ListNode headB)
        {
            ListNode pA = headA;
            ListNode pB = headB;
            while (pA != pB)
            {
                pA = pA == null ? headB : pA.next;
                pB = pB == null ? headA : pB.next;
            }

            return pA;
        }

        public ListNode getIntersectionNode(ListNode headA, ListNode headB)
        {
            var count1 = 0;
            var count2 = 0;
            var first = headA;
            var second = headB;

            while (first != null)
            {
                count1++;
                first = first.next;
            }

            while (second != null)
            {
                count2++;
                second = second.next;
            }

            if (count1 < count2)
            {
                return GetResult(headB, headA, count2, count1);
            }
            else
            {
                return GetResult(headA, headB, count1, count2);
            }
        }

        public ListNode GetResult(ListNode nodeA, ListNode nodeB, int count1, int count2)
        {
            var difference = count1 - count2;
            var count = 0;
            while (nodeA != nodeB)
            {
                if (count >= difference)
                {
                    nodeB = nodeB.next;
                }

                nodeA = nodeA.next;
                count++;
            }

            return nodeA;
        }
    }
}
