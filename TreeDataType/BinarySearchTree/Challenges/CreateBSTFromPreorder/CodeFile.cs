using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDataType.BinaryTree;

namespace TreeDataType.BinarySearchTree.Challenges.CreateBSTFromPreorder
{
    public class CodeFile
    {
        public Node<int> Root { get; set; }

        // Method to create a BST from preorder traversal
        public Node<int> CreateTree(int[] array)
        {
            if (array == null || array.Length == 0) return null;

            // Initialize the root node with the first element
            var stack = new Stack<Node<int>>();
            Root = new Node<int>(array[0]);
            var current = Root;

            // Iterate through the remaining elements
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < current.Value)
                {
                    // Create a left child node
                    var childNode = new Node<int>(array[i]);
                    current.Left = childNode;
                    stack.Push(current);
                    current = childNode;
                }
                else
                {
                    // Find the parent node for the right child
                    while (stack.Count > 0 && array[i] > stack.Peek().Value)
                    {
                        current = stack.Pop();
                    }

                    // Create a right child node
                    var childNode = new Node<int>(array[i]);
                    current.Right = childNode;
                    current = childNode;
                }
            }

            return Root;
        }
    }

}
