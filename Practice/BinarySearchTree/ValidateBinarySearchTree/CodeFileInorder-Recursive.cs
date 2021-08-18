using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearchTree.ValidateBinarySearchTree
{
    class CodeFileInorder_Recursive
    {
        int? lastValue = null;
        public bool IsValidBST(TreeNode root)
        {
            return ValidateInOrder(root);
        }

        public bool ValidateInOrder(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            if (!ValidateInOrder(root.left))
            {
                return false;
            }

            if (lastValue.HasValue && root.val <= lastValue)
            {
                return false;
            }

            lastValue = root.val;
            return ValidateInOrder(root.right);
        }
    }
}
