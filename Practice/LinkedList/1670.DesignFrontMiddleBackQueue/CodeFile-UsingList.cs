using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._1670.DesignFrontMiddleBackQueue
{
    public class FrontMiddleBackQueueList
    {
        List<int> list;
        public FrontMiddleBackQueueList()
        {
            list = new List<int>();
        }

        public void PushFront(int val)
        {
            list.Insert(0, val);
        }

        public void PushMiddle(int val)
        {
            var mid = GetMiddle(false);
            list.Insert(mid, val);
        }

        public void PushBack(int val)
        {
            list.Add(val);
        }

        public int PopFront()
        {
            if (list.Count == 0) return -1;

            var val = list[0];
            list.RemoveAt(0);

            return val;
        }

        public int PopMiddle()
        {
            if (list.Count == 0) return -1;

            var mid = GetMiddle(true);
            var val = list[mid];
            list.RemoveAt(mid);
            return val;
        }

        public int PopBack()
        {
            if (list.Count == 0) return -1;
            var last = list.Count - 1;
            var val = list[last];
            list.RemoveAt(last);
            return val;
        }

        private int GetMiddle(bool lower)
        {
            var offset = lower ? 1 : 0;
            var mid = (list.Count - offset) / 2;

            if (mid < 0)
                mid = 0;
            return mid;
        }
    }

}
