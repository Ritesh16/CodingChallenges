using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.MaxDepth
{
    public class CodeFile
    {
        public int MaxDepth(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            Stack<int> depths = new Stack<int>();
            if (root == null) return 0;

            stack.Push(root);
            depths.Push(1);

            int depth = 0, current_depth = 0;
            while (stack.Count != 0)
            {
                root = stack.Pop();
                current_depth = depths.Pop();
                if (root != null)
                {
                    depth = Math.Max(depth, current_depth);
                    stack.Push(root.left);
                    stack.Push(root.right);
                    depths.Push(current_depth + 1);
                    depths.Push(current_depth + 1);
                }
            }
            return depth;
        }
    }
}
