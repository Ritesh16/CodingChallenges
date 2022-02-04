using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._641.DesignCircularDeque
{
    public class MyCircularDeque
    {
        int maxSize = 0;
        int count = 0;
        DoubleLinkedListNode head;
        DoubleLinkedListNode tail;

        public MyCircularDeque(int k)
        {
            maxSize = k;
        }

        public bool InsertFront(int value)
        {
            if (count >= maxSize)
            {
                return false;
            }

            var newNode = new DoubleLinkedListNode(value, null, null);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Last = newNode;
                head = newNode;
            }

            count++;

            return true;
        }

        public bool InsertLast(int value)
        {
            if (count >= maxSize)
            {
                return false;
            }

            var newNode = new DoubleLinkedListNode(value, null, null);
            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Last = tail;
                tail.Next = newNode;
                tail = newNode;
            }

            count++;

            return true;
        }

        public bool DeleteFront()
        {
            if (count == 0)
            {
                return false;
            }

            head = head.Next;
            if (head == null)
            {
                tail = null;
            }
            else
            {
                head.Last = null;
            }

            count--;
            return true;
        }

        public bool DeleteLast()
        {
            if (count == 0)
            {
                return false;
            }

            tail = tail.Last;
            if (tail == null)
            {
                head = null;
            }
            else
            {
                tail.Next = null;
            }

            count--;
            return true;
        }

        public int GetFront()
        {
            return count > 0 ? head.Val : -1;
        }

        public int GetRear()
        {
            return count > 0 ? tail.Val : -1;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == maxSize;
        }
    }

    public class DoubleLinkedListNode
    {
        public int Val { get; set; }
        public DoubleLinkedListNode Next { get; set; }
        public DoubleLinkedListNode Last { get; set; }

        public DoubleLinkedListNode(int val, DoubleLinkedListNode next, DoubleLinkedListNode last)
        {
            Val = val;
            Next = next;
            Last = last;
        }
    }

}
