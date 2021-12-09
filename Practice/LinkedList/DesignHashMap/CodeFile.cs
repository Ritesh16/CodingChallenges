using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.DesignHashMap
{
    public class MyHashMap
    {
        Node[] nodes;
        int count = 256;
        public MyHashMap()
        {
            nodes = new Node[count];
        }

        public void Put(int key, int value)
        {
            var node = nodes[key % nodes.Length];
            if (node == null)
            {
                nodes[key % nodes.Length] = new Node(key, value);
            }
            else
            {
                while (node.Next != null && node.Key != key)
                {
                    node = node.Next;
                }

                if (node.Key == key)
                {
                    node.Value = value;
                }
                else
                {
                    node.Next = new Node(key, value);
                }
            }
        }

        public int Get(int key)
        {
            var node = nodes[key % nodes.Length];
            while (node != null && node.Key != key)
            {
                node = node.Next;
            }

            if (node == null)
            {
                return -1;
            }
            else
            {
                return node.Value;
            }
        }

        public void Remove(int key)
        {
            var node = nodes[key % nodes.Length];
            if (node == null) return;

            if (node.Key == key) nodes[key % nodes.Length] = node.Next;
            else
            {
                while (node.Next != null && node.Next.Key != key)
                {
                    node = node.Next;
                }

                if (node.Next != null && node.Next.Key == key)
                {
                    node.Next = node.Next.Next;
                }
            }


        }
    }

    public class Node
    {
        public int Key { get; set; }
        public int Value { get; set; }

        public Node Next { get; set; }

        public Node(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}
