using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._114.FlattenBinaryTree
{
    public class CodeFile_Recursive
    {
        public void Flatten(TreeNode root)
        {
            if (root == null) return;

            var leftTree = root.left;
            var rightTree = root.right;

            root.left = null;

            Flatten(leftTree);
            Flatten(rightTree);

            root.right = leftTree;

            var curr = root;
            while (curr.right != null)
            {
                curr = curr.right;
            }

            curr.right = rightTree;
        }
    }
}
