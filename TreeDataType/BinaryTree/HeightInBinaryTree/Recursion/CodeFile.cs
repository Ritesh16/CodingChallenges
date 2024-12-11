using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataType.BinaryTree.HeightInBinaryTree.Recursion
{
    public class CodeFile<T>
    {
        public int CalculateHeight(Node<T> root)
        {
            if (root == null) return -1;
            
            int leftHeight = CalculateHeight(root.Left); 
            int rightHeight = CalculateHeight(root.Right);
            
            return Math.Max(leftHeight, rightHeight) + 1;

        }
    }
}
