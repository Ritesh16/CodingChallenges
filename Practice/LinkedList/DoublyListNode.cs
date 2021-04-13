using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList
{
    public class DoublyListNode
    {
        public int val;
        public DoublyListNode next, prev;
        public DoublyListNode(int x) 
        {
            val = x;
            next = null;
            prev = null;
        }
    }
}
