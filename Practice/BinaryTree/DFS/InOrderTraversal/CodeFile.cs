using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.DFS.InOrderTraversal
{
    public class CodeFile
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var output = new List<int>();
            var stack = new Stack<TreeNode>();
            if (root == null)
            {
                return output;
            }

            var node = root;
            while (node != null || stack.Count != 0)
            {
                while (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }

                node = stack.Peek();
                
                if (node.right == null) 
                {
                    node = stack.Pop();
                    output.Add(node.val);
                }
                else
                {
                    stack.Push(node.right);
                }
              
            }

            return output;
        }
    }
}
