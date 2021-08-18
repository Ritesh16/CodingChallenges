using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearchTree.ValidateBinarySearchTree
{
    class CodeFileInorder_Iterative
    {
        int? lastValue = null;
        public bool IsValidBST(TreeNode root)
        {
            return ValidateInOrder_Iterative(root);
        }

        public bool ValidateInOrder_Iterative(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var result = true;
            var stack = new Stack<TreeNode>();
            var node = root;

            while (node != null || stack.Count != 0)
            {
                while (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }

                node = stack.Pop();

                if (lastValue.HasValue && node.val <= lastValue)
                {
                    result = false;
                    break;
                }

                lastValue = node.val;
                node = node.right;
            }

            return result;
        }
    }
}
