using Practice.BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._109.ConvertSortedListToBinaryTree
{
    public class CodeFile
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            return ToBST(head, null);
        }

        public TreeNode ToBST(ListNode first, ListNode last)
        {
            if (first == last)
            {
                return null;
            }

            var slow = first;
            var fast = first;
            while (fast != last && fast.next != last)
            {
                slow = slow.next;
                fast = fast.next.next;
            }


            TreeNode treeNode = new TreeNode(slow.val);
            treeNode.left = ToBST(first, slow);
            treeNode.right = ToBST(slow.next, last);


            return treeNode;
        }
    }
}
