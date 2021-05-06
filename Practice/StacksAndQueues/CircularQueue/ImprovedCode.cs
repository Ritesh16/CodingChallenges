using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StacksAndQueues.CircularQueue
{
    public class MyCircularQueue_I
    {
        int[] array;
        int length;
        int head = 0;
        int tail = 0;
        public MyCircularQueue_I(int k)
        {
            array = new int[k];
            length = 0;
            head = 0;
            tail = -1;
        }

        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }

            tail = (tail + 1) % array.Length;
            array[tail] = value;
            length++;
            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }

            head = (head + 1) % array.Length;
            length--;

            return true;
        }

        public int Front()
        {
            return IsEmpty() ? -1 : array[head];
        }

        public int Rear()
        {
            return IsEmpty() ? -1 : array[tail];
        }

        public bool IsEmpty()
        {
            return length == 0;
        }

        public bool IsFull()
        {
            return length == array.Length;
        }
    }
}
