using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.SearchBinaryTree
{
    class CodeFile_Recursive
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {

            if (root == null || root.val == val)
            {
                return root;
            }

            if (root.val < val)
            {
                return SearchBST(root.right, val);
            }
            else
            {
                return SearchBST(root.left, val);
            }
        }
    }
}
