using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StacksAndQueues.MovingAverage
{
    public class MovingAverage
    {
        int[] queue;
        int size;
        int tail;
        int head;
        int count;
        int sum;
        public MovingAverage(int size)
        {
            queue = new int[size];
            this.size = size;
            head = 0;
            tail = 0;
            count = 0;
            sum = 0;
        }

        public double Next(int val)
        {
            count++;
            tail = (head + 1) % size;

            sum = sum - queue[tail] + val;

            head = (head + 1) % size;
            queue[head] = val;

            return sum * 1.0 / Math.Min(count, size);
        }
    }
}
