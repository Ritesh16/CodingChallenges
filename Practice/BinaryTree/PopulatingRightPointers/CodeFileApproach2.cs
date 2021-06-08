using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.PopulatingRightPointers
{
    class CodeFileApproach2
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return root;
            }

            Node leftMost = root;
            while (leftMost.left != null)
            {
                var head = leftMost;
                while (head != null)
                {
                    head.left.next = head.right;

                    if (head.next != null)
                    {
                        head.right.next = head.next.left;
                    }

                    head = head.next;
                }

                leftMost = leftMost.left;
            }

            return root;
        }
    }
}
