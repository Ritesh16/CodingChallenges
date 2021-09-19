using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearchTree.DeleteBST
{
    class CodeFile_Fast
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null) return null;

            if (key > root.val)
            {
                root.right = DeleteNode(root.right, key);
            }
            else if (key < root.val)
            {
                root.left = DeleteNode(root.left, key);
            }
            else
            {
                if (root.left == null && root.right == null) root = null;
                else if (root.right != null)
                {
                    root.val = FindSuccessor(root);
                    root.right = DeleteNode(root.right, root.val);
                }
                else
                {
                    root.val = FindPredessor(root);
                    root.left = DeleteNode(root.left, root.val);
                }
            }

            return root;
        }

        private int FindPredessor(TreeNode root)
        {
            root = root.left;
            while (root.right != null) root = root.right;
            return root.val;
        }

        private int FindSuccessor(TreeNode root)
        {
            root = root.right;
            while (root.left != null) root = root.left;
            return root.val;
        }
    }
}
