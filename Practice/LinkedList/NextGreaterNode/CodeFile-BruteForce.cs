using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.NextGreaterNode
{
    internal class CodeFile_BruteForce
    {
        public int[] NextLargerNodes(ListNode head)
        {
            var node = head;
            var result = new List<int>();
            var max = 0;

            while (node != null)
            {
                max = 0;
                var current = node.next;
                while (current != null)
                {
                    if (node.val < current.val)
                    {
                        max = current.val;
                        break;
                    }


                    current = current.next;
                }


                result.Add(max);
                node = node.next;
            }


            return result.ToArray();
        }
    }
}
