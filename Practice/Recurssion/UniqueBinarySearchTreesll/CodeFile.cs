using Practice.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.UniqueBinarySearchTreesll
{
    class CodeFile
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n == 0)
            {
                return new List<TreeNode>();
            }

            return GenerateTrees(1, n);
        }

        private IList<TreeNode> GenerateTrees(int start, int end)
        {
            var output = new List<TreeNode>();
            if (start > end)
            {
                output.Add(null);
                return output;
            }

            for (int i = start; i <= end; i++)
            {
                var leftNodes = GenerateTrees(start, i - 1);
                var rightNodes = GenerateTrees(i + 1, end);

                foreach (var leftNode in leftNodes)
                {
                    foreach (var rightNode in rightNodes)
                    {
                        TreeNode node = new TreeNode(i);
                        node.left = leftNode;
                        node.right = rightNode;

                        output.Add(node);
                    }
                }
            }



            return output;
        }
    }
}
