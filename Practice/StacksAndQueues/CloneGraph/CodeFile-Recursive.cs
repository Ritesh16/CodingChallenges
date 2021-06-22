using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StacksAndQueues.CloneGraph
{
    public class CodeFile
    {
        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        public Node CloneGraph(Node node)
        {
            if (node == null)
            {
                return null;
            }

            if (map.ContainsKey(node))
            {
                return map[node];
            }

            var cloneNode = new Node(node.val, new List<Node>());
            map.Add(node, cloneNode);

            foreach (var n in node.neighbors)
            {
                cloneNode.neighbors.Add(CloneGraph(n));
            }

            return cloneNode;
        }
    }
}
