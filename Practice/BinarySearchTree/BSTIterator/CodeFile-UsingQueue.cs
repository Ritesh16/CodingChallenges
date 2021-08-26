using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearchTree.BSTIterator
{
    class CodeFile_UsingQueue
    {
        Queue<TreeNode> outputStack = new Queue<TreeNode>();
        public CodeFile_UsingQueue(TreeNode root)
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
                outputStack.Enqueue(node);
                node = node.right;
            }

        }

        public int Next()
        {
            if (outputStack.Count > 0)
            {
                var node = outputStack.Dequeue();
                return node.val;
            }

            return -1;
        }

        public bool HasNext()
        {
            return outputStack.Count > 0;
        }
    }
}
