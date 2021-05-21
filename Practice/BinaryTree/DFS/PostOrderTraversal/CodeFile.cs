using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.DFS.PostOrderTraversal
{
    public class CodeFile
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            IList<int> result = new List<int>();
            TreeNode lastNode = null;
            TreeNode peek = null;


            while ((lastNode == null && root != null) || stack.Count != 0)
                if (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                else if ((peek = stack.Peek()).right != null && peek.right != lastNode)
                    root = peek.right;
                else
                {
                    result.Add(peek.val);
                    lastNode = stack.Pop();
                }
            return result;
        }
    }
}
