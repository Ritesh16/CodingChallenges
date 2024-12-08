using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataType.BinaryTree.Traversal.DFS.Inorder.Recursive
{
    public class CodeFile<T>
    {
        public void Traverse(Node<T> node)
        {
            if (node != null)
            {
                Traverse(node.Left);
                Console.WriteLine(node.Value);
                Traverse(node.Right);
            }
        }
    }
}
