using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataType.AVL.Types
{

    public class AVLTree<T> where T : IComparable<T>
    {
        private AVLTreeNode<T> root;

        public int Height(AVLTreeNode<T> node)
        {
            return node?.Height ?? 0;
        }

        public int BalanceFactor(AVLTreeNode<T> node)
        {
            return node == null ? 0 : Height(node.Left) - Height(node.Right);
        }

        public void UpdateHeight(AVLTreeNode<T> node)
        {
            node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));
        }

        public AVLTreeNode<T> RotateRight(AVLTreeNode<T> y)
        {
            AVLTreeNode<T> x = y.Left;
            AVLTreeNode<T> T2 = x.Right;

            x.Right = y;
            y.Left = T2;

            UpdateHeight(y);
            UpdateHeight(x);

            return x;
        }

        public AVLTreeNode<T> RotateLeft(AVLTreeNode<T> x)
        {
            AVLTreeNode<T> y = x.Right;
            AVLTreeNode<T> T2 = y.Left;

            y.Left = x;
            x.Right = T2;

            UpdateHeight(x);
            UpdateHeight(y);

            return y;
        }

        public AVLTreeNode<T> Insert(AVLTreeNode<T> node, T value)
        {
            if (node == null)
            {
                return new AVLTreeNode<T>(value);
            }

            int compare = value.CompareTo(node.Value);

            if (compare < 0)
            {
                node.Left = Insert(node.Left, value);
            }
            else if (compare > 0)
            {
                node.Right = Insert(node.Right, value);
            }
            else
            {
                return node;
            }

            UpdateHeight(node);

            int balance = BalanceFactor(node);

            // Left Left Case
            if (balance > 1 && value.CompareTo(node.Left.Value) < 0)
            {
                return RotateRight(node);
            }

            // Right Right Case
            if (balance < -1 && value.CompareTo(node.Right.Value) > 0)
            {
                return RotateLeft(node);
            }

            // Left Right Case
            if (balance > 1 && value.CompareTo(node.Left.Value) > 0)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            // Right Left Case
            if (balance < -1 && value.CompareTo(node.Right.Value) < 0)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }

        public void Insert(T value)
        {
            root = Insert(root, value);
        }

        public AVLTreeNode<T> MinValueNode(AVLTreeNode<T> node)
        {
            AVLTreeNode<T> current = node;

            while (current.Left != null)
            {
                current = current.Left;
            }

            return current;
        }

        public AVLTreeNode<T> Delete(AVLTreeNode<T> root, T value)
        {
            if (root == null)
            {
                return root;
            }

            int compare = value.CompareTo(root.Value);

            if (compare < 0)
            {
                root.Left = Delete(root.Left, value);
            }
            else if (compare > 0)
            {
                root.Right = Delete(root.Right, value);
            }
            else
            {
                if ((root.Left == null) || (root.Right == null))
                {
                    AVLTreeNode<T> temp = root.Left ?? root.Right;

                    if (temp == null)
                    {
                        root = null;
                    }
                    else
                    {
                        root = temp;
                    }
                }
                else
                {
                    AVLTreeNode<T> temp = MinValueNode(root.Right);

                    root.Value = temp.Value;

                    root.Right = Delete(root.Right, temp.Value);
                }
            }

            if (root == null)
            {
                return root;
            }

            UpdateHeight(root);

            int balance = BalanceFactor(root);

            // Left Left Case
            if (balance > 1 && BalanceFactor(root.Left) >= 0)
            {
                return RotateRight(root);
            }

            // Left Right Case
            if (balance > 1 && BalanceFactor(root.Left) < 0)
            {
                root.Left = RotateLeft(root.Left);
                return RotateRight(root);
            }

            // Right Right Case
            if (balance < -1 && BalanceFactor(root.Right) <= 0)
            {
                return RotateLeft(root);
            }

            // Right Left Case
            if (balance < -1 && BalanceFactor(root.Right) > 0)
            {
                root.Right = RotateRight(root.Right);
                return RotateLeft(root);
            }

            return root;
        }

        public void Delete(T value)
        {
            root = Delete(root, value);
        }

        public void PreOrder(AVLTreeNode<T> node)
        {
            if (node != null)
            {
                Console.Write(node.Value + " ");
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }

        public void PreOrderTraversal()
        {
            PreOrder(root);
        }
    }

}
