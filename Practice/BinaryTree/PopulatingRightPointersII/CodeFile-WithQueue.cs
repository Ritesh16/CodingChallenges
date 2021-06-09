using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.PopulatingRightPointersII
{
    class CodeFile_WithQueue
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return root;
            }

            var queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    if (i < size - 1)
                    {
                        node.next = queue.Peek();
                    }

                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
            }

            return root;
        }
    }
}
