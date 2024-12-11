using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataType.BinaryTree.CountLeafNodes.Recursive
{
    public class CodeFile<T>
    {
        public int CountLeafNodes(Node<T> root)
        {
            if (root == null) return 0;

            if (root.Left == null && root.Right == null)
            {
                return 1;
            }
            
            int left = CountLeafNodes(root.Left);
            int right = CountLeafNodes(root.Right);

            return left + right;
        }

        public int CountNodesWith2Children(Node<T> root)
        {
            if (root == null) return 0;

            var count = 0;
            if (root.Left != null && root.Right != null)
            {
                count = 1;
            }

            count += CountNodesWith2Children(root.Left);
            count += CountNodesWith2Children(root.Right);

            return count;
        }

        public int CountNodesWith1Children(Node<T> root)
        {
            if (root == null) return 0;

            var count = 0;
            if (root.Left != null ^ root.Right != null)
            {
                count = 1;
            }

            count += CountNodesWith1Children(root.Left);
            count += CountNodesWith1Children(root.Right);

            return count;
        }
    }
}
