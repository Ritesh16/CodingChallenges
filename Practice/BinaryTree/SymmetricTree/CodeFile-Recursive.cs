using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.SymmetricTree
{
    public class CodeFileRecursive
    {
        public bool IsSymmetric(TreeNode root)
        {

            var result = true;
            result = Check(root.left, root.right);

            return result;
        }

        //private bool Check(TreeNode node1, TreeNode node2)
        //{
        //    if (node1 != null && node2 != null)
        //    {
        //        if (node1.val == node2.val)
        //        {
        //            var result = Check(node1.left, node2.right);
        //            var result2 = Check(node1.right, node2.left);

        //            if (!result || !result2)
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                return true;
        //            }
        //        }
        //    }

        //    if (node1 == null && node2 == null)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        private bool Check(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null)
            {
                return true;
            }

            if (node1 != null && node2 != null && (node1.val == node2.val))
            {
                var result1 = Check(node1.left, node2.right);
                var result2 = Check(node1.right, node2.left);
                return result1 && result2;

            }

            return false;
        }
    }
}
