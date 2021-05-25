using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.SymmetricTree
{
    public class CodeFile
    {
        public bool IsSymmetric(TreeNode root)
        {

            var result = true;
            //result = Check(root.left, root.right);
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root.left);
            queue.Enqueue(root.right);
            while (queue.Count > 0)
            {
                var item1 = queue.Dequeue();
                var item2 = queue.Dequeue();
                if (item1 == null && item2 == null) continue;

                if (item1 != null && item2 != null && item1.val == item2.val)
                {
                    result = true;
                    queue.Enqueue(item1.left);
                    queue.Enqueue(item2.right);

                    queue.Enqueue(item1.right);
                    queue.Enqueue(item2.left);
                }
                else
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
