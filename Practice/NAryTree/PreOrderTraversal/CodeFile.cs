using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.NAryTree.PreOrderTraversal
{
    class CodeFile
    {
        public IList<int> Preorder(Node root)
        {
            var output = new List<int>();

            if (root == null)
            {
                return output;
            }

            var stack = new Stack<Node>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                output.Add(node.val);

                if (node.children != null)
                {
                    for (int i = node.children.Count - 1; i >= 0; i--)
                    {
                        stack.Push(node.children[i]);
                    }
                }
            }


            return output;
        }
    }
}
