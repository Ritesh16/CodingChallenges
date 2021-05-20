using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.DFS.PreOrderTraversal
{
    public class CodeFile_Recursive
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var output = new List<int>();
            PreOrder_Recursive(root, output);
            return output;
        }

        public void PreOrder_Recursive(TreeNode root, List<int> output)
        {
            if (root == null)
            {
                return;
            }

            if (root != null)
            {
                output.Add(root.val);
            }

            PreOrder_Recursive(root.left, output);
            PreOrder_Recursive(root.right, output);
        }
    }
}
