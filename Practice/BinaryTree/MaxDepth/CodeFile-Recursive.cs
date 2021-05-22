using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.MaxDepth
{
    public class CodeFile_Recursive
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int left_height = MaxDepth(root.left);
                int right_height = MaxDepth(root.right);
                return 1 + Math.Max(left_height, right_height);
            }
        }
    }
}
