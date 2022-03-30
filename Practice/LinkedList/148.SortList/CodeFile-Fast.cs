using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._148.SortList
{
    public class CodeFile_Fast
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            List<int> values = new List<int>();
            while (head != null)
            {
                values.Add(head.val);
                head = head.next;
            }
            values.Sort();
            head = new ListNode();
            ListNode current = head;
            foreach (int val in values)
            {
                current.next = new ListNode(val);
                current = current.next;
            }
            return head.next;
        }
    }
}
