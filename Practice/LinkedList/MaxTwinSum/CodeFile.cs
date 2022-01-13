using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.MaxTwinSum
{
    internal class CodeFile
    {
        public int PairSum(ListNode head)
        {
            var current = head;
            var fast = head;
            var stack = new Stack<int>();

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                stack.Push(current.val);
                current = current.next;
            }

            var max = -1;
            while (stack.Count > 0 && current != null)
            {
                var val = stack.Pop();
                max = Math.Max(max, val + current.val);
                current = current.next;
            }

            return max;
        }
    }
}
