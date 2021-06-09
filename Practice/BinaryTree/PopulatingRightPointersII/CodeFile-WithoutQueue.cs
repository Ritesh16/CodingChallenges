using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.PopulatingRightPointersII
{
    class CodeFile_WithoutQueue
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return root;
            }

            Node leftMost = null, current = null, previous = null;
            leftMost = root;

            while (leftMost != null)
            {
                previous = null;
                current = leftMost;
                leftMost = null;

                while (current != null)
                {
                    ProcessNode(current.left);
                    ProcessNode(current.right);
                    current = current.next;
                }
            }

            void ProcessNode(Node child)
            {
                if (child == null)
                {
                    return;
                }

                if (previous == null)
                {
                    leftMost = child;
                }
                else
                {
                    previous.next = child;
                }

                previous = child;
            }


            return root;
        }
    }
}
