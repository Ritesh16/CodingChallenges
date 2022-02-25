using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.ConvertBinaryToInteger
{
    public class CodeFile_Fast
    {
        public int GetDecimalValue(ListNode head)
        {
            var result = head.val;
            while (head.next != null)
            {
                result = 2 * result + head.next.val;
                head = head.next;
            }

            return result;
        }
    }
}
