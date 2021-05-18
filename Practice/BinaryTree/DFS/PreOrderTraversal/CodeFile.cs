using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.DFS.PreOrderTraversal
{
    public class CodeFile
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var output = new List<int>();
            var stack = new Stack<TreeNode>();
            if (root == null)
            {
                return output;
            }

            stack.Push(root);

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (node.right != null)
                {
                    stack.Push(node.right);
                }

                if (node.left != null)
                {
                    stack.Push(node.left);
                }

                output.Add(node.val);
            }

            return output;
        }
    }
}
