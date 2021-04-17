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
        Dictionary<Node, Node> dictionary = new Dictionary<Node, Node>();
        public Node CopyRandomList(Node head)
        {
            if (head == null)
            {
                return head;
            }

            var oldNode = head;
            var newNode = new Node(head.val);
            dictionary.Add(oldNode, newNode);
            while (oldNode != null)
            {
                newNode.random = GetClonedNode(oldNode.random);
                newNode.next = GetClonedNode(oldNode.next);

                oldNode = oldNode.next;
                newNode = newNode.next;
            }

            return dictionary[head];
        }

        private Node GetClonedNode(Node head)
        {
            if (head != null)
            {
                if (dictionary.ContainsKey(head))
                {
                    return dictionary[head];
                }
                else
                {
                    var newNode = new Node(head.val);
                    dictionary.Add(head, newNode);
                    return dictionary[head];
                }
            }

            return null;
        }


        // Recurssion
        //    public Node CopyRandomList(Node head)
        //{
        //    if (head == null) return null;

        //    Dictionary<Node, Node> dictionary = new Dictionary<Node, Node>();
        //    if (dictionary.ContainsKey(head))
        //    {
        //        return dictionary.GetValueOrDefault(head);
        //    }

        //    Node node = new Node(head.val);
        //    dictionary.Add(head, node);

        //    node.next = CopyRandomList(head.next);
        //    node.random = CopyRandomList(head.random);

        //    return node;
        //}
    }
}
