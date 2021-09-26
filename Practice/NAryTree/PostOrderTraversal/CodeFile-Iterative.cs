using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.NAryTree.PostOrderTraversal
{
    public class CodeFile_Iterative
    {
        public IList<int> Postorder(Node root)
        {
            var stack = new Stack<Node>();
            var output = new List<int>();

            if (root == null)
            {
                return output;
            }

            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                output.Add(node.val);

                if (node.children != null)
                {
                    foreach (var item in node.children)
                    {
                        stack.Push(item);
                    }

                }
            }

            output.Reverse();

            return output;
        }
    }
}
