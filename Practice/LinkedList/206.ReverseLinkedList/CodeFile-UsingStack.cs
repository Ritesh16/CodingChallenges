using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.ReverseLinkedList
{
    public class CodeFile_UsingStack
    {
        public ListNode ReverseList(ListNode head)
        {
            var stack = new Stack<ListNode>();
            var resultNode = new ListNode(int.MinValue);
            var node = resultNode;

            while (head != null)
            {
                if (head.val != int.MinValue)
                {
                    stack.Push(head);
                    head = head.next;
                }
            }

            while (stack.Count > 0)
            {
                node.next = stack.Peek();
                node = node.next;
                stack.Pop();
            }

            node.next = null;
            return resultNode.next;
        }
    }
}
