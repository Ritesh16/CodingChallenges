using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.LCA
{
    public class CodeFile_Iterative
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            var parent = new Dictionary<TreeNode, TreeNode>();
            parent.Add(root, null);

            while (!(parent.ContainsKey(p)) || !parent.ContainsKey(q))
            {
                var node = stack.Pop();

                if (node.left != null)
                {
                    parent.Add(node.left, node);
                    stack.Push(node.left);
                }

                if (node.right != null)
                {
                    parent.Add(node.right, node);
                    stack.Push(node.right);
                }
            }

            var ancestors = new HashSet<TreeNode>();
            while (p != null)
            {
                ancestors.Add(p);
                p = parent[p];
            }

            while (!ancestors.Contains(q))
            {
                q = parent[q];
            }

            return q;
        }

    }
}
