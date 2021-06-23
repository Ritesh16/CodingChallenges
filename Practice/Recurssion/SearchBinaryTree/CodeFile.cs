using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.SearchBinaryTree
{
    class CodeFile
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            while (root != null && val != root.val)
            {
                root = val < root.val ? root.left : root.right;
            }

            return root;
        }
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
            {
                return root;
            }

            TreeNode result = null;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node.val == val)
                {
                    result = node;
                    break;
                }

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            return result;
        }
    }
}
