using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearchTree.InsertInBST
{
    class CodeFile_Recursive
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            return Insert(root, val);
        }
        public TreeNode Insert(TreeNode root, int val)
        {
            if (root == null) return new TreeNode(val);

            if (val <= root.val)
                root.left = InsertIntoBST(root.left, val);
            else
                root.right = InsertIntoBST(root.right, val);

            return root;
        }
    }
}
