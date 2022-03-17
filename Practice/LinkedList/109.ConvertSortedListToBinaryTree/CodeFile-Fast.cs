using Practice.BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._109.ConvertSortedListToBinaryTree
{
    public class CodeFile_Fats
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            var list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            return ToBST(list, 0, list.Count - 1);
        }

        private TreeNode ToBST(List<int> list, int left, int right)
        {
            if (left > right) return null;

            var mid = left + (right - left) / 2;
            TreeNode node = new TreeNode(list[mid]);
            node.left = ToBST(list, left, mid - 1);
            node.right = ToBST(list, mid + 1, right);
            return node;
        }
    }
}
