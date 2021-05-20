using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.DFS.PostOrderTraversal
{
    public class CodeFile_Recursive
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var output = new List<int>();
            Postorder_Recursive(root, output);
            return output;
        }

        private void Postorder_Recursive(TreeNode root, List<int> output)
        {
            if (root == null)
            {
                return;
            }

            Postorder_Recursive(root.left, output);
            Postorder_Recursive(root.right, output);
            if (root != null)
            {
                output.Add(root.val);
            }
        }
    }
}
