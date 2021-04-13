using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.DoublyLinkedList
{
    public class MyLinkedList
    {
        private DoublyListNode head;
        private int Count;
        public MyLinkedList()
        {
            head = null;
            Count = 0;
        }

        public int Get(int index)
        {
            var node = GetNode(index);
            return node == null ? -1 : node.val;
        }
        public void addAtIndex(int index, int val)
        {
            if (index == 0)
            {
                addAtHead(val);
                return;
            }

            var lastNode = GetNode(index - 1);
            if (lastNode == null)
            {
                return;
            }

            var node = new DoublyListNode(val);
            var next = lastNode.next;

            lastNode.next = node;
            node.prev = lastNode;

            node.next = next;
            next.prev = node;
            Count++;
        }
        public void addAtTail(int val)
        {
            if (head == null)
            {
                addAtHead(val);
                return;
            }

            var tail = GetTailNode();
            var node = new DoublyListNode(val);
            node.prev = tail;
            tail.next = node;
            tail = node;
            Count++;
        }

        public void addAtHead(int val)
        {
            var node = new DoublyListNode(val);

            if (head != null)
            {
                var temp = head;
                temp.prev = node;
            }

            node.next = head;
            head = node;
            Count++;
        }

        public void DeleteAtIndex(int index)
        {
            var node = GetNode(index);
            if (node == null)
            {
                return;
            }

            var next = node.next;
            var prev = node.prev;

            if (prev != null)
            {
                prev.next = next;
            }
            else
            {
                head = next;
            }

            if (next != null)
            {
                next.prev = prev;
            }
           
            Count--;
        }

        private DoublyListNode GetNode(int index)
        {
            if (index < 0)
            {
                return null;
            }

            DoublyListNode node = head;
            for (int i = 0; i < index; i++)
            {
                node = node?.next;
            }

            return node;

        }

        private DoublyListNode GetTailNode()
        {
            DoublyListNode node = head;
            while (node.next != null)
            {
                node = node.next;
            }

            return node;

        }

    }
}
