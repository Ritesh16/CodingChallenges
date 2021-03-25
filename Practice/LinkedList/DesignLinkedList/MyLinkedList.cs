using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.DesignLinkedList
{
    public class MyLinkedList
    {
        public int Count { get; set; }
        public LinkedListNode Head;
        public LinkedListNode Tail;

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
            LinkedListNode head = Head;
            for (int i = 0; i < index; ++i)
            {
                if (head != null)
                    head = head.Next;
            }

            return head;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            if (Head == null)
            {
                Head = new LinkedListNode(val);
                Tail = Head;
            }
            else
            {
                var node = new LinkedListNode(val);
                node.Next = Head;
                Head = node;
            }

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
            else
            {
                var tail = new LinkedListNode(val);

                Tail.Next = tail;
                Tail = tail;
            }

            Count++;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index > Count || index < 0)
            {
                return;
            }

            if (index == 0)
            {
                AddAtHead(val);
                return;
            }

            if (index == Count)
            {
                AddAtTail(val);
                return;
            }

            var head = Head;
            var i = 0;
            while (head != null)
            {
                if (i == index - 1)
                {
                    var node = new LinkedListNode(val);
                    var next = head.Next;

                    head.Next = node;
                    head.Next.Next = next;
                }

                i++;
                head = head.Next;
            }

            Count++;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index >= Count || index < 0)
            {
                return;
            }

            if (index == 0)
            {
                Head = Head.Next;
            }

            var head = Head;
            var i = 0;
            while (head != null)
            {
                if (i == index - 1)
                {
                    if (head.Next == null)
                    {
                        Head = null;
                        Tail = null;
                    }
                    else
                    {
                        head.Next = head.Next.Next;
                    }

                    break;
                }

                i++;
                head = head.Next;
            }



            Count--;
            if (Count == 0)
            {
                Head = null;
                Tail = null;
            }

        }
    }
}
