using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinaryTree.BFS.LevelOrderTraversal
{
    public class CodeFile
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var output = new List<IList<int>>();

            if (root == null)
            {
                return output;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var list = new List<int>();
            list.Add(root.val);
            output.Add(list);
            while (queue.Count > 0)
            {
                list = new List<int>();
                var level = queue.Count;
                for (int i = 0; i < level; i++)
                {
                    var node = queue.Dequeue();

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                        list.Add(node.left.val);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                        list.Add(node.right.val);
                    }
                }

                if (list.Count > 0)
                    output.Add(list);
            }

            return output;
        }
    }
}
