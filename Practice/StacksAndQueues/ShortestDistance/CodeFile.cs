using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StacksAndQueues.ShortestDistance
{
    public class CodeFile
    {
        public int BFS(Node root, Node target)
        {
            Queue<Node> queue = new Queue<Node>();  
            int step = 0;       
                                
            queue.Enqueue(root);
            // BFS
            while (queue.Count != 0)
            {
                step = step + 1;
                // iterate the nodes which are already in the queue
                int size = queue.Count;
                for (int i = 0; i < size; ++i)
                {
                    Node cur = queue.Peek();
                    if (cur.Equals(target)) return step;
                    foreach (var item in cur.Nodes)
                    {
                        queue.Enqueue(item);
                    }

                    queue.Dequeue();
                }
            }

            return -1;          // there is no path from root to target
        }
    }
}
