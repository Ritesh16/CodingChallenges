using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearchTree.InorderSuccessorinBST
{
    class CodeFile_Any_BST
    {
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            TreeNode successor = null;
            while (root != null)
            {
                if (p.val >= root.val)
                {
                    root = root.right;
                }
                else
                {
                    successor = root;
                    root = root.left;
                }
            }

            return successor;
        }
    }
}
