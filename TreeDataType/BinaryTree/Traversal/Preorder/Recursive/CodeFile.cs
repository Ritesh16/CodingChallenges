﻿namespace TreeDataType.BinaryTree.Traversal.Preorder.Recursive
{
    public class CodeFile<T>
    {
        public void Traverse(Node<T> node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                Traverse(node.Left);
                Traverse(node.Right);
            }
        }
    }
}
