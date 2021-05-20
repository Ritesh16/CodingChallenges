using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.DFS.InOrderTraversal
{
    public class CodeFile_Recursive
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var output = new List<int>();
            InOrder_Recursive(root, output);
            return output;
        }

        private void InOrder_Recursive(TreeNode root, List<int> output)
        {
            if (root == null)
            {
                return;
            }

            InOrder_Recursive(root.left, output);
            if (root != null)
            {
                output.Add(root.val);
            }

            InOrder_Recursive(root.right, output);
        }
    }
}
