using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.NextGreaterNode
{
    internal class CodeFile
    {
        public int[] NextLargerNodes(ListNode head)
        {
            var current = head;
            var list = new List<int>();

            while (current != null)
            {
                list.Add(current.val);
                current = current.next;
            }

            var result = new int[list.Count];
            var stack = new Stack<int>();

            for (int i = 0; i < list.Count; i++)
            {
                while (stack.Count != 0 && list[stack.Peek()] < list[i])
                {
                    result[stack.Pop()] = list[i];
                }

                stack.Push(i);
            }

            return result;
        }
    }
}
