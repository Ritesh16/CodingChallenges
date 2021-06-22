using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StacksAndQueues.CloneGraph
{
    class CodeFile_Iterative
    {
        public Node CloneGraph(Node node)
        {
            if (node == null)
            {
                return null;
            }

            var queue = new Queue<Node>();
            var dic = new Dictionary<Node, Node>();

            queue.Enqueue(node);
            dic.Add(node, new Node(node.val, new List<Node>()));

            while (queue.Count > 0)
            {
                var n = queue.Dequeue();
                foreach (var neighbor in n.neighbors)
                {
                    if (!dic.ContainsKey(neighbor))
                    {
                        dic.Add(neighbor, new Node(neighbor.val, new List<Node>()));
                        queue.Enqueue(neighbor);
                    }

                    dic[n].neighbors.Add(dic[neighbor]);
                }
            }

            return dic[node];
        }
    }
}
