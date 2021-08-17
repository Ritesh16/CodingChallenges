using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearchTree.ValidateBinarySearchTree
{
    class CodeFileIterative
    {
        public bool IsValidBST(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            var lower = new Stack<int?>();
            var upper = new Stack<int?>();

            stack.Push(root);
            lower.Push(null);
            upper.Push(null);

            while (stack.Count != 0)
            {
                var node = stack.Pop();
                var low = lower.Pop();
                var high = upper.Pop();
                if (node == null) continue;
                if ((low.HasValue && node.val <= low) || (high.HasValue && node.val >= high))
                {
                    return false;
                }


                stack.Push(node.right);
                lower.Push(node.val);
                upper.Push(high);
                stack.Push(node.left);
                upper.Push(node.val);
                lower.Push(low);
            }

            return true;
        }
    }
}
