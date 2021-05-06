using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StacksAndQueues.MovingAverage
{
    public class MovingAverage1
    {

        Queue<int> queue;
        int cap;
        public MovingAverage1(int size)
        {
            cap = size;
            queue = new Queue<int>(size);
        }

        public double Next(int val)
        {
            if (queue.Count == cap)
            {
                queue.Dequeue();
            }

            queue.Enqueue(val);
            var sum = 0;
            foreach (var item in queue)
            {
                sum += item;
            }

            double s = (double)sum / queue.Count;
            return s;
        }
    }
}
