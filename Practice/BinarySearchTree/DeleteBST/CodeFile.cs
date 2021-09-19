using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearchTree.DeleteBST
{
    class CodeFile
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            TreeNode parent = null;
            TreeNode node = root;

            while (node != null && node.val != key)
            {
                parent = node;
                node = node.val > key ? node.left : node.right;
            }

            if (node == null) return root;

            TreeNode replacement = FindReplacement(node.left, node.right);

            if (parent == null)
            {
                return replacement;
            }
            else
            {
                if (parent.left == node) parent.left = replacement;
                if (parent.right == node) parent.right = replacement;
            }

            return root;
        }

        private TreeNode FindReplacement(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return null;
            if (left == null) return right;
            if (right == null) return left;

            TreeNode head = left;
            while (left.right != null) left = left.right;

            left.right = right;
            return head;
        }
    }
}
