using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.PathSum
{
    class CodeFile
    {
        //public bool HasPathSum(TreeNode root, int targetSum)
        //{

        //    if (root == null)
        //    {
        //        return false;
        //    }

        //    var stack = new Stack<(TreeNode node, int sum)>();
        //    stack.Push((root, root.val));

        //    while (stack.Count > 0)
        //    {
        //        var item = stack.Pop();
        //        var node = item.node;
        //        var sum = item.sum;

        //        if (node.right != null)
        //        {
        //            stack.Push((node.right, sum + node.right.val));
        //        }

        //        if (node.left != null)
        //        {
        //            stack.Push((node.left, sum + node.left.val));
        //        }

        //        if (node.left == null && node.right == null && sum == targetSum)
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
        public bool HasPathSum(TreeNode root, int targetSum)
        {

            if (root == null)
            {
                return false;
            }

            var stack = new Stack<(TreeNode node, int sum)>();
            stack.Push((root, root.val));

            while (stack.Count > 0)
            {
                var item = stack.Pop();
                var node = item.node;
                var sum = item.sum;

                if (node.right != null)
                {
                    stack.Push((node.right, sum + node.right.val));
                }

                if (node.left != null)
                {
                    stack.Push((node.left, sum + node.left.val));
                }

                if (node.left == null && node.right == null && sum == targetSum)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
