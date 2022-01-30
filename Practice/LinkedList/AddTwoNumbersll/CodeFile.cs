using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.AddTwoNumbersll
{
    public class CodeFile
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var stack1 = new Stack<ListNode>();
            var stack2 = new Stack<ListNode>();
            var resultStack = new Stack<ListNode>();

            FillStack(l1, stack1);
            FillStack(l2, stack2);

            var carry = 0;

            while (stack1.Count > 0 || stack2.Count > 0)
            {
                var digit1 = stack1.Count > 0 ? stack1.Pop().val : 0;
                var digit2 = stack2.Count > 0 ? stack2.Pop().val : 0;

                var sum = digit1 + digit2 + carry;
                var currentDigit = sum % 10;
                carry = sum / 10;

                resultStack.Push(new ListNode(currentDigit));

            }

            if (carry != 0)
            {
                resultStack.Push(new ListNode(carry));
            }

            if (resultStack.Count == 0)
            {
                return null;
            }

            var res = resultStack.Pop();
            var node = res;
            while (resultStack.Count > 0)
            {
                node.next = resultStack.Pop();
                node = node.next;
            }

            return res;
        }
        public void FillStack(ListNode listNode, Stack<ListNode> stack)
        {
            while (listNode != null)
            {
                stack.Push(listNode);
                listNode = listNode.next;
            }
        }
    }
}
