using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDataType.Traversal.BFS
{
    public class CodeFile
    {
        public int Vertices { get; set; }
        private List<int>[] adjacentList;
        public CodeFile(int vertices)
        {
            Vertices = vertices + 1;

            adjacentList = new List<int>[Vertices];
            for (int i = 0; i < Vertices; i++)
            {
                adjacentList[i] = new List<int>();
            }
        }

        public void AddEdge(int source, int destination)
        {
            adjacentList[source].Add(destination);
        }

        public void BFS(int start)
        {
            bool[] visited = new bool[Vertices];
            var queue = new Queue<int>();

            visited[start] = true;
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.WriteLine(current);

                foreach (var neighbour in adjacentList[current])
                {
                    if (!visited[neighbour])
                    {
                        visited[neighbour] = true;
                        queue.Enqueue(neighbour);
                    }
                }
            }
        }
    }
}
