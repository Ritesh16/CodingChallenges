using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree._617.MergeTwoBinaryTrees
{
    public class CodeFile
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null)
                return root2;


            var stack = new Stack<TreeNode[]>();
            stack.Push(new TreeNode[] { root1, root2 });

            while (stack.Count > 0)
            {
                var t = stack.Pop();
                if (t[0] == null || t[1] == null)
                    continue;

                t[0].val += t[1].val;

                if (t[0].left == null)
                {
                    t[0].left = t[1].left;
                }
                else
                {
                    stack.Push(new TreeNode[] { t[0].left, t[1].left });
                }

                if (t[0].right == null)
                {
                    t[0].right = t[1].right;
                }
                else
                {
                    stack.Push(new TreeNode[] { t[0].right, t[1].right });
                }
            }

            return root1;
        }
    }
}
