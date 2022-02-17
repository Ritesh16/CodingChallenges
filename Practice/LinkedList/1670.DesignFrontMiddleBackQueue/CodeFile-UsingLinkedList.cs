using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._1670.DesignFrontMiddleBackQueue
{
    public class FrontMiddleBackQueue
    {
        ListNode head;
        ListNode tail;
        int count = 0;
        public FrontMiddleBackQueue()
        {
            head = new ListNode(0);
        }

        public void PushFront(int val)
        {
            var node = new ListNode(val);

            count++;
            if (count == 1)
            {
                tail = node;
                head = node;
            }
            else
            {
                var temp = head;
                node.next = temp;
                head = node;
            }
        }

        public void PushMiddle(int val)
        {
            if (count <= 1)
            {
                PushFront(val);
                return;
            }

            var root = head;
            var mid = count / 2;
            var i = 0;
            while (i < mid - 1)
            {
                i++;
                root = root.next;
            }

            var node = new ListNode(val);
            var temp = root.next;
            root.next = node;
            node.next = temp;
            count++;
        }

        public void PushBack(int val)
        {
            var node = new ListNode(val);

            count++;
            if (count == 1)
            {
                tail = node;
                head = node;
            }
            else
            {
                var temp = tail;
                temp.next = node;
                tail = node;
            }
        }

        public int PopFront()
        {
            if (count == 0) return -1;

            count--;
            var temp = head;
            head = head.next;

            return temp.val;
        }

        public int PopMiddle()
        {
            if (count == 0) return -1;
            if (count <= 2)
            {
                return PopFront();
            }

            var root = head;
            var mid = (count - 1) / 2;


            var i = 0;
            while (i < mid - 1)
            {
                i++;
                root = root.next;
            }

            var temp = root.next.val;
            root.next = root.next.next;
            count--;

            return temp;
        }

        public int PopBack()
        {
            if (count == 0) return -1;

            var i = 0;
            var root = head;
            while (i < count - 2)
            {
                root = root.next;
                i++;
            }

            var val = tail.val;
            root.next = null;
            tail = root;
            count--;
            return val;
        }
    }
}
