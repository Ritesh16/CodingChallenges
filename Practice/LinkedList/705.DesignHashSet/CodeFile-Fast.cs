using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._705.DesignHashSet
{
    public class MyHashSet
    {
        List<bool> list;
        public MyHashSet()
        {
            list = new List<bool>();
        }

        public void Add(int key)
        {
            if (list.Count - 1 < key)
            {
                for (int i = list.Count; i < key + 1; i++)
                {
                    list.Add(false);
                }
            }

            list[key] = true;
        }

        public void Remove(int key)
        {
            if (list.Count > key)
            {
                list[key] = false;
            }
        }

        public bool Contains(int key)
        {
            return list.Count > key && list[key];
        }
    }
}
