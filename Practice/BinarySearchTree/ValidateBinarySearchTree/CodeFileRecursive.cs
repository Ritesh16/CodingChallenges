using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearchTree.ValidateBinarySearchTree
{
    class CodeFileRecursive
    {
        public bool IsValidBST(TreeNode root)
        {
            return Validate(root, null, null);
        }

        public bool Validate(TreeNode root, int? low, int? high)
        {
            if (root == null)
            {
                return true;
            }

            if ((low.HasValue && root.val <= low) || (high.HasValue && root.val >= high))
            {
                return false;
            }

            return Validate(root.right, root.val, high) && Validate(root.left, low, root.val);
        }
    }
}
