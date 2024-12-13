using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDataType.BinarySearchTree.Types.Interfaces;
using TreeDataType.BinaryTree;

namespace TreeDataType.BinarySearchTree.Types
{
    public class BinarySearchTree : IBinarySearchTree
    {
        public Node<int> Root { get; set; }

        public Node<int> Delete(int value)
        {
            if (Root == null) return null;

            var root = Root;
            Node<int> parent = null;
            while (root != null && root.Value != value)
            {
                parent = root;
                root = root.Value > value ? root.Left : root.Right;
            }

            // If the node to be deleted is not found
            if (root == null) return Root;

            Node<int> replacement = FindReplacement(root.Left, root.Right);
            if (parent == null)
            {
                Root = replacement;
            }
            else
            {
                if (parent.Left == root) parent.Left = replacement;
                else parent.Right = replacement;
            }

            return Root;
        }

        public Node<int> Insert(int value)
        {
            var node = new Node<int>();
            node.Value = value;

            if (Root == null)
            {
                Root = node;
                return Root;
            }

            var root = Root;
            Node<int> previous = null;
            while (root != null)
            {
                previous = root;
                if (root.Value > value)
                {
                    root = root.Left;
                }
                else
                {
                    root = root.Right;
                }
            }

            if (previous.Value > value)
            {
                previous.Left = node;
            }
            else
            {
                previous.Right = node;
            }

            return Root;
        }

        public Node<int> Insert(Node<int> root, int value)
        {
            if (root == null)
            {
                var node = new Node<int>(value);
                root = node;
                return root;
            }

            if (root.Value > value)
            {
                root.Left = Insert(root.Left, value);
            }
            else
            {
                root.Right = Insert(root.Right, value);
            }


            return root;
        }

        private Node<int> FindReplacement(Node<int> left, Node<int> right)
        {
            if (left == null && right == null) return null;

            if (left == null) return right;
            if (right == null) return left;

            var rightmost = left; 
            Node<int> parentOfRightmost = null; // Find the rightmost node in the left subtree
            while (rightmost.Right != null) 
            { 
                parentOfRightmost = rightmost; 
                rightmost = rightmost.Right; 
            } 
            
            // If the rightmost node has a left child, it needs to be linked
            
            if (parentOfRightmost != null) 
            { 
                parentOfRightmost.Right = rightmost.Left; 
                rightmost.Left = left; 
             } 
            
            rightmost.Right = right;
            return rightmost;
        }
    }
}
