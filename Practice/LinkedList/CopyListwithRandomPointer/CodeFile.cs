using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.CopyListwithRandomPointer
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
    public class CodeFile
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;

            Dictionary<Node, Node> dictionary = new Dictionary<Node, Node>();
            if (dictionary.ContainsKey(head))
            {
                return dictionary.GetValueOrDefault(head);
            }

            Node node = new Node(head.val);
            dictionary.Add(head, node);

            node.next = CopyRandomList(head.next);
            node.random = CopyRandomList(head.random);

            return node;
        }
    }
}
