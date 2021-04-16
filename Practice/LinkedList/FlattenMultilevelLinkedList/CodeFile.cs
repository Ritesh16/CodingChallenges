using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.FlattenMultilevelLinkedList
{
    public class CodeFile
    {
        public Node Flatten(Node head)
        {
            if (head == null) return null;

            Node dummyHead = new Node(-1);
            dummyHead.next = head;
            Node curr;
            Node prev = dummyHead;
            Stack<Node> stack = new Stack<Node>();
            stack.Push(head);

            while (stack.Count > 0)
            {
                curr = stack.Pop();
                prev.next = curr;
                curr.prev = prev;

                if (curr.next != null)
                {
                    stack.Push(curr.next);
                }

                if (curr.child != null)
                {
                    stack.Push(curr.child);
                    curr.child = null;
                }

                prev = curr;
            }

            dummyHead.next.prev = null;

            return dummyHead.next;

        }

        // Recurssion
        Node prev = null;
        public Node Flatten1(Node head)
        {
            if (head == null)
            {
                return null;
            }

            head.prev = prev;
            prev = head;

            var next = head.next;

            head.next = Flatten1(head.child);
            head.child = null;

            prev.next = Flatten1(next);

            return head;
        }

    }

    public class Node
    {
        public int val;
        public Node prev;
        public Node next;
        public Node child;

        public Node(int val)
        {
            this.val = val;
        }
    }
}
