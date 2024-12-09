using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataType.BinaryTree.CountNodesInBinaryTree.Iterative
{
    public class CodeFile<T>
    {
        public int Count(Node<T> root)
        {
            var stack = new Stack<Node<T>>();
            var output = 0;
            stack.Push(root);

            while (stack.Count > 0)
            {
                var top = stack.Pop();
                if (top != null)
                {
                    stack.Push(top.Right);
                    stack.Push(top.Left);
                    output++;
                }
            }

            return output;
        }
    }
}
