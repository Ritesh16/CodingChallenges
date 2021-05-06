using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StacksAndQueues.CircularQueue
{
    public class MyCircularQueue
    {

        int[] array;
        int length;
        int head = -1;
        int tail = -1;
        public MyCircularQueue(int k)
        {
            array = new int[k];
            length = k;
        }

        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }

            var result = false;
            if (head == -1)
            {
                head = 0;
            }

            if (head > 0 && tail == length - 1) tail = -1;

            if (tail < length - 1)
            {
                tail++;
                array[tail] = value;
                result = true;
            }

            return result;
        }

        public bool DeQueue()
        {
            var result = false;
            if (head == -1)
            {
                return result;
            }

            if (head == tail)
            {
                array[head] = 0;
                head = -1;
                tail = -1;
                return true;
            }

            array[head] = -1;
            head++;

            if (head == length && head != tail)
            {
                head = 0;
            }

            result = true;
            return result;
        }

        public int Front()
        {
            if (head == -1) return -1;
            return array[head];
        }

        public int Rear()
        {
            if (tail == -1) return -1;
            return array[tail];
        }

        public bool IsEmpty()
        {
            var result = false;
            if (tail == -1 && head == -1) result = true;

            return result;
        }

        public bool IsFull()
        {
            var result = false;
            if (head == 0 && tail == length - 1)
            {
                result = true;
            }

            if (head - 1 == tail)
            {
                result = true;
            }

            return result;
        }
    }

}
