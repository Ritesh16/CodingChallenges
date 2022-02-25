using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._2181.MergeNodesBetweenZeros
{
    public class CodeFile
    {
        public ListNode MergeNodes(ListNode head)
        {
            var sum = 0;
            var root = head;
            ListNode result = null;
            root = root.next;
            ListNode previous = null;
            while (root != null)
            {
                if (root.val != 0)
                {
                    sum += root.val;
                }
                else
                {
                    var node = new ListNode(sum);

                    if (result == null)
                    {
                        result = node;
                        previous = result;
                    }
                    else
                    {
                        previous.next = node;
                        previous = previous.next;
                    }

                    sum = 0;
                }

                root = root.next;
            }

            return result;
        }
    }
}
