using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.DesignLinkedList
{
    public class LinkedListNode
    {
        public LinkedListNode(int val)
        {
            Value = val;
        }
        public int Value { get; set; }
        public LinkedListNode Next { get; set; }
    }
}
