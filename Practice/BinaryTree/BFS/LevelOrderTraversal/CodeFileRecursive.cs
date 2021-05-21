using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.BFS.LevelOrderTraversal
{
    public class CodeFileRecursive
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var output = new List<IList<int>>();
            Helper(root, output, 0);
            return output;
        }

        public void Helper(TreeNode root, IList<IList<int>> output, int level)
        {
            if (root == null)
            {
                return;
            }

            if (output.Count > level)
            {
                var list = output[level];
                list.Add(root.val);
            }
            else
            {
                var list = new List<int>();
                list.Add(root.val);
                output.Add(list);
            }

            level++;
            Helper(root.left, output, level);
            Helper(root.right, output, level);
        }
    }
}
