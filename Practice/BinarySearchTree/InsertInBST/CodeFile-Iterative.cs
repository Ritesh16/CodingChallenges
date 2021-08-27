using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearchTree.InsertInBST
{
    class CodeFile_Iterative
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            return Insert(root, val);
        }
        public TreeNode Insert(TreeNode root, int val)
        {
            TreeNode newNode = new TreeNode(val);
            if (root == null)
            {
                return newNode;
            }

            TreeNode curr = root;
            TreeNode target = curr;

            while (curr != null)
            {
                target = curr;
                curr = (curr.val >= val) ? curr.left : curr.right;
            }

            if (target.val >= val)
                target.left = newNode;
            else
                target.right = newNode;

            return root;
        }
    }
}
