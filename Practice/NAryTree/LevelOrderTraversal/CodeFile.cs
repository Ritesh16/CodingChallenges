using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.NAryTree.LevelOrderTraversal
{
    public class CodeFile
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            var output = new List<IList<int>>();
            var queue = new Queue<Node>();
            if (root == null)
            {
                return output;
            }

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var size = queue.Count;
                var list = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();


                    list.Add(node.val);
                    if (node.children != null)
                    {
                        foreach (var item in node.children)
                        {
                            queue.Enqueue(item);
                        }

                    }
                }

                output.Add(list);
            }

            return output;
        }
    }
}
