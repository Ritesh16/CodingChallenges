﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.Intersectionof2LinkedList
{
    public class CodeFile
    {
        public ListNode getIntersectionNode(ListNode headA, ListNode headB)
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
    }
}
