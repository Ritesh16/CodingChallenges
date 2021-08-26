using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearchTree.BSTIterator
{
    class CodeFile_BetterApproach
    {
        Stack<TreeNode> stack;

        public CodeFile_BetterApproach(TreeNode root)
        {
            stack = new Stack<TreeNode>();
            Helper(root);
        }

        public int Next()
        {
            var node = stack.Pop();
            if (node.right != null)
            {
                Helper(node.right);
            }

            return node.val;
        }

        public bool HasNext()
        {
            return stack.Count > 0;
        }

        private void Helper(TreeNode root)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }
        }
    }
}
