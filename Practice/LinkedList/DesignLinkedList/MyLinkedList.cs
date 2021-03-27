using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.DesignLinkedList
{
    public class MyLinkedList
    {
        public int Count { get; set; }
        public LinkedListNode Head;

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            Head = null;
        }

        public MyLinkedList(int val)
        {
            if (Head == null)
            {
                var head = new LinkedListNode(val);
            }
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            var node = GetNode(index);

            return node == null ? -1 : node.Value;
        }

        private LinkedListNode GetNode(int index)
        {
            if (index < 0)
            {
                return null;
            }

            LinkedListNode head = Head;
            for (int i = 0; i < index; ++i)
            {
                if (head != null)
                    head = head.Next;
            }

            return head;
        }

        private LinkedListNode GetTail()
        {
            LinkedListNode cur = Head;
            while (cur != null && cur.Next != null)
            {
                cur = cur.Next;
            }

            return cur;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            var node = new LinkedListNode(val);
            node.Next = Head;
            Head = node;

            Count++;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            if (Head == null)
            {
                AddAtHead(val);
                return;
            }

            var tail = GetTail();
            var node = new LinkedListNode(val);
            tail.Next = node;

            Count++;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                AddAtHead(val);
                return;
            }


            var prevNode = GetNode(index - 1);
            if (prevNode == null)
            {
                return;
            }

            var next = prevNode.Next;
            var newNode = new LinkedListNode(val);
            prevNode.Next = newNode;
            newNode.Next = next;

            Count++;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index >= Count || index < 0)
            {
                return;
            }

            var currNode = GetNode(index);
            if (currNode == null)
            {
                return;
            }

            var prev = GetNode(index - 1);
            if (prev != null)
            {
                prev.Next = currNode.Next;
            }
            else
            {
                // modify head when deleting the first node.
                Head = currNode.Next;
            }

            Count--;
        }
    }
}
