namespace TreeDataType.BinaryTree.Traversal.BFS.Levelorder.Iterative
{
    public class CodeFile<T>
    {
        public List<T> Traverse(Node<T> root)
        {
            var queue = new Queue<Node<T>>();
            var output = new List<T>();

            if (root == null) return output;

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node != null)
                {
                    output.Add(node.Value);

                    queue.Enqueue(node.Left);
                    queue.Enqueue(node.Right);
                }
            }

            return output;
        }
    }
}
