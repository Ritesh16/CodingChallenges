using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearchTree.InorderSuccessorinBST
{
    class CodeFile_Any_BT
    {
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            var stack = new Stack<TreeNode>();
            var index = -1;
            TreeNode output = null;
            var list = new List<TreeNode>();

            var node = root;
            while (node != null || stack.Count != 0)
            {
                while (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }

                node = stack.Pop();
                if (node.val == p.val)
                {
                    index = list.Count;
                }

                list.Add(node);
                node = node.right;

                if (index != -1 && list[list.Count - 1].val != p.val && index < list.Count)
                {
                    break;
                }
            }

            if (index + 1 < list.Count)
            {
                output = list[index + 1];
            }

            return output;
        }
    }
}
