using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearchTree.BSTIterator
{
    class CodeFile_UsingArray
    {
        List<int> output = new List<int>();
        int index = 0;
        public CodeFile_UsingArray(TreeNode root)
        {
            var stack = new Stack<TreeNode>();

            var node = root;
            while (node != null || stack.Count != 0)
            {
                while (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }

                node = stack.Pop();
                output.Add(node.val);
                node = node.right;
            }

        }

        public int Next()
        {
            if (output.Count > 0)
            {
                var val = output[index];
                index++;
                return val;
            }

            return -1;
        }

        public bool HasNext()
        {
            return index < output.Count;
        }
    }
}
