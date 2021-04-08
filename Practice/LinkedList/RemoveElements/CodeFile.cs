using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.RemoveElements
{
    public class CodeFile
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            var sentinal = new ListNode(-1);
            sentinal.next = head;

            var previous = sentinal;
            var current = head;
            while (current != null)
            {
                if(current.val == val)
                {
                    var next = current.next;
                    previous.next = next;
                    current = next;
                }
                else
                {
                    previous = current;
                    current = current.next;
                }
            }

            return sentinal.next;
        }
    }
}
