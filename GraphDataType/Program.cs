// See https://aka.ms/new-console-template for more information
Console.WriteLine("Graph");

var graph = new GraphDataType.Traversal.CodeFile(7);
graph.AddEdge(1, 2);
graph.AddEdge(1, 3);
graph.AddEdge(1, 4);
graph.AddEdge(2, 3);
graph.AddEdge(3, 4);
graph.AddEdge(3, 5);
graph.AddEdge(4, 5);
graph.AddEdge(5, 6);
graph.AddEdge(5, 7);

graph.BFS(1);

Console.WriteLine();

graph.DFS(1);

