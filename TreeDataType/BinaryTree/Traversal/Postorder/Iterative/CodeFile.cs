using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataType.BinaryTree.Traversal.Postorder.Iterative
{
    public class CodeFile<T>
    {
        public List<T> Traverse(Node<T> node)
        {
            var stack = new Stack<Node<T>>();
            var output = new List<T>();
            Node<T> previousNode = null;

            while (node != null || stack.Count > 0)
            {
                while (node != null)
                {
                    stack.Push(node);
                    node = node.Left;
                }

                node = stack.Peek();
                if (node.Right != null && node.Right != previousNode)
                {
                    node = node.Right;
                }
                else
                {
                    node = stack.Pop();
                    output.Add(node.Value);
                    previousNode = node;
                    node = null;
                }
            }

            return output;
        }
    }
}
