using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._725.SplitLinkedListinParts
{
    public class CodeFile_Fast
    {
        public ListNode[] SplitListToParts(ListNode head, int k)
        {
            var result = new ListNode[k];
            var list = new List<ListNode>();

            while (head != null)
            {
                list.Add(head);
                head = head.next;
            }

            var remainder = list.Count % k;
            var width = list.Count / k;
            var i = 0;

            for (int j = 0; j < result.Length; j++)
            {
                if (j >= list.Count)
                    break;

                result[j] = list[i];

                if (j < remainder)
                {
                    i += width + 1;
                }
                else
                {
                    i += width;
                }

                list[i - 1].next = null;
            }

            return result;
        }
    }
}
