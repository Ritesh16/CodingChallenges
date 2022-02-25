using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList.ConvertBinaryToInteger
{
    internal class CodeFile
    {
        public int GetDecimalValue(ListNode head)
        {
            var node = head;
            var builder = new StringBuilder();
            while (node != null)
            {
                builder.Append(node.val);
                node = node.next;
            }

            return Convert.ToInt32(builder.ToString(), 2);
        }
    }
}
