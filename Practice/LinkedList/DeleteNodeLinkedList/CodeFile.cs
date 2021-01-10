using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.DeleteNodeLinkedList
{
    public class CodeFile
    {
        public ListNode Load()
        {
            var node = new ListNode(1);
            node.Next = new ListNode(2);
            node.Next.Next = new ListNode(3);
            node.Next.Next.Next = new ListNode(4);
            node.Next.Next.Next.Next = new ListNode(5);

            return node;
        }
        public void DeleteNode(ListNode node)
        {
            node.Value = node.Next.Value;
            node.Next = node.Next.Next;
        }
    }

    public class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }
        public ListNode(int val)
        {
            Value = val;
        }
    }
}
