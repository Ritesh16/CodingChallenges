using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.InsertInSorteCircularLL
{
    public class Node
    {
        public int val;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
            next = null;
        }

        public Node(int _val, Node _next)
        {
            val = _val;
            next = _next;
        }
    }
    public class CodeFile
    {
        public Node Insert(Node head, int insertVal)
        {
            if (head == null)
            {
                var node = new Node(insertVal);
                node.next = node;
                return node;
            }

            var prev = head;
            var curr = head.next;
            var insert = false;

            do
            {
                if (insertVal <= curr.val && insertVal > prev.val)
                {
                    insert = true;
                }
                else if (prev.val > curr.val)
                {
                    if (insertVal >= prev.val || insertVal <= curr.val)
                    {
                        insert = true;
                    }
                }

                if (insert)
                {
                    var node = new Node(insertVal);
                    prev.next = node;
                    node.next = curr;
                    return head;
                }

                prev = curr;
                curr = curr.next;

            } while (head != prev);


            prev.next = new Node(insertVal, curr);

            return head;
        }
    }
}
