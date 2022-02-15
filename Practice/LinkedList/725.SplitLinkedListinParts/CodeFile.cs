using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._725.SplitLinkedListinParts
{
    public class CodeFile
    {
        public ListNode[] SplitListToParts(ListNode head, int k)
        {
            if (head == null) return new ListNode[k];

            var length = GetLength(head);
            var parts = length / k;

            var array = new int[k];
            for (int i = 0; i < k; i++)
            {
                array[i] = parts;
            }


            var remainder = length % k;
            for (int i = 0; i < remainder; i++)
            {
                array[i]++;
            }


            var result = new ListNode[k];

            for (int i = 0; i < array.Length; i++)
            {
                var total = array[i];
                var counter = 0;
                ListNode node = head;
                var prev = node;
                while (counter < total)
                {
                    counter++;
                    prev = node;
                    node = node.next;
                }

                if (prev != null)
                {
                    prev.next = null;
                }

                result[i] = head;
                head = node;
            }

            return result;
        }

        public int GetLength(ListNode head)
        {
            var count = 0;
            var root = head;
            while (root != null)
            {
                count++;
                root = root.next;
            }

            return count;
        }
    }
}
