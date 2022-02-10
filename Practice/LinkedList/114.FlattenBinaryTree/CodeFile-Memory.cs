using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._114.FlattenBinaryTree
{
    public class CodeFile_Memory
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        public void Flatten(TreeNode root)
        {
            if (root == null) return;
            PreOrder(root);

            var node = queue.Dequeue();
            while (queue.Count > 0)
            {
                node.right = queue.Dequeue();
                node.left = null;
                node = node.right;
            }
        }

        public void PreOrder(TreeNode node)
        {
            if (node == null) return;

            queue.Enqueue(node);
            PreOrder(node.left);
            PreOrder(node.right);
        }
    }
}
