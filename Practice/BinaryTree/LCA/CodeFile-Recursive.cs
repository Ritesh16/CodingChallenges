using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.LCA
{
    public class CodeFile_Recursive
    {
        TreeNode ans;

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            RecurseTree(root, p, q);
            return ans;
        }

        public bool RecurseTree(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return false;
            }

            int left = RecurseTree(root.left, p, q) ? 1 : 0;

            int right = RecurseTree(root.right, p, q) ? 1 : 0;

            int mid = (root == p || root == q) ? 1 : 0;

            if (left + right + mid >= 2)
            {
                ans = root;
            }

            return (left + right + mid) > 0;
        }

    }
}
