using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.DesignHashSet
{
    public class MyHashSet
    {
        List<int>[] list;
        int count = 256;
        public MyHashSet()
        {
            list = new List<int>[count];
        }

        public void Add(int key)
        {
            if (Contains(key)) return;

            var slot = key % count;
            var item = list[slot];

            if (item == null)
            {
                list[slot] = new List<int>();
            }

            list[slot].Add(key);
        }

        public void Remove(int key)
        {
            var slot = key % count;
            var item = list[slot];

            if (item == null) return;

            for (int i = 0; i < list[slot].Count; i++)
            {
                if (list[slot][i] == key)
                {
                    list[slot].RemoveAt(i);
                }
            }
        }

        public bool Contains(int key)
        {
            var slot = key % count;
            var item = list[slot];

            if(item == null) return false;

            for (int i = 0; i < list[slot].Count; i++)
            {
                if(list[slot][i] == key)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
