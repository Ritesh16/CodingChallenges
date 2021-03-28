using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.LinkedListCycleII
{
    public class CodeFile
    {
        // O(1) --- Space
        //  O(n) --- Time
        public ListNode DetectCycle(ListNode head)
        {
            var hashTable = new HashSet<ListNode>();
            var elem = head;
            while (elem != null)
            {
                if (hashTable.Contains(elem))
                {
                    return elem;
                }

                hashTable.Add(elem);
                elem = elem.next;
            }

            return null;
        }
        // O(1) --- Space
        //  O(n) --- Time
        public ListNode DetectCycle1(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            var intersect = GetIntersection(head);
            if (intersect == null)
            {
                return null;
            }

            var ptr1 = head;
            var ptr2 = intersect;
            while (ptr1 != ptr2)
            {
                ptr1 = ptr1.next;
                ptr2 = ptr2.next;
            }

            return ptr1;

        }

        private static ListNode GetIntersection(ListNode head)
        {
            var first = head;
            var second = head;

            while (second != null && second.next != null)
            {
                first = first?.next;
                second = second?.next?.next;

                if (second == first)
                {
                    return second;
                }
            }

            return null;
        }
    }
}
