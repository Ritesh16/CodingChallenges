using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._2074.ReverseNodesinEvenLengthGroups
{
    public class CodeFile
    {
        public ListNode ReverseEvenLengthGroups(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode result = new ListNode(int.MinValue);
            var current = result;
            var stack = new Stack<ListNode>();
            var queue = new Queue<ListNode>();
            var count = 0;
            var group = 1;
            while (head != null)
            {
                stack.Push(new ListNode(head.val));
                queue.Enqueue(new ListNode(head.val));
                count++;

                if (count == group)
                {
                    if (group == 1 || group % 2 == 0)
                    {
                        current = StackProcessing(stack, queue, current);
                    }
                    else
                    {
                        current = QueueProcessing(stack, queue, current);
                    }

                    count = 0;
                    group++;
                }

                head = head.next;
            }

            if (count > 0)
            {
                if (count % 2 == 0)
                {
                    current = StackProcessing(stack, queue, current);

                }
                else
                {
                    current = QueueProcessing(stack, queue, current);
                }
            }


            return result.next;

        }

        public ListNode StackProcessing(Stack<ListNode> stack, Queue<ListNode> queue, ListNode current)
        {
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                current.next = new ListNode(node.val);
                current = current.next;
                if (queue.Count > 0) queue.Dequeue();
            }

            return current;
        }
        public ListNode QueueProcessing(Stack<ListNode> stack, Queue<ListNode> queue, ListNode current)
        {
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                current.next = new ListNode(node.val);
                current = current.next;
                if (stack.Count > 0) stack.Pop();
            }

            return current;
        }
    }
}
