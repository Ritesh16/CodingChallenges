using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.LinkedList._114.FlattenBinaryTree
{
    public class CodeFile_Iterative
    {
        public void Flatten(TreeNode root)
        {
            var node = root;
            while (root != null)
            {
                if (root.left != null)
                {
                    if (root.right == null)
                    {
                        root.right = root.left;
                    }
                    else
                    {
                        var nextRight = root.right;
                        root.right = root.left;
                        var cur = root.right;
                        while (cur.right != null)
                        {
                            cur = cur.right;
                        }

                        cur.right = nextRight;
                    }

                    root.left = null;
                }

                root = root.right;
            }
        }
    }
}
