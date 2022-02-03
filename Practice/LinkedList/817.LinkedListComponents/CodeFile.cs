using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._817.LinkedListComponents
{
    internal class CodeFile
    {
        public int NumComponents(ListNode head, int[] nums)
        {
            var count = 0;
            var hashSet = new HashSet<int>(nums);
            var connected = false;

            while (head != null)
            {
                if (hashSet.Add(head.val))
                {
                    connected = false;
                }
                else if (!connected)
                {
                    count++;
                    connected = true;
                }

                head = head.next;
            }

            return count;
        }
    }
}
