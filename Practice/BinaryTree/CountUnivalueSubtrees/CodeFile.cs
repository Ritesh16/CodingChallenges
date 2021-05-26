using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.CountUnivalueSubtrees
{
    public class CodeFile
    {
        int count = 0;
        public int CountUnivalSubtrees(TreeNode root)
        {
            if (root == null) return count;

            IsUnival(root);

            return count;
        }

        private bool IsUnival(TreeNode node)
        {
            if (node.left == null && node.right == null)
            {
                count++;
                return true;
            }

            var is_unival = true;

            // check if all of the node's children are univalue subtrees and if they have the same value
            // also recursively call is_uni for children
            if (node.left != null)
            {
                is_unival = IsUnival(node.left) && is_unival && node.left.val == node.val;
            }

            if (node.right != null)
            {
                is_unival = IsUnival(node.right) && is_unival && node.right.val == node.val;
            }

            // return if a univalue tree exists here and increment if it does
            if (!is_unival) return false;
            count++;
            return true;
        }
    }
}
