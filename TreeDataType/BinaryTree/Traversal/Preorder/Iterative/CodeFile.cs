namespace TreeDataType.BinaryTree.Traversal.Preorder.Iterative
{
    public class CodeFile<T>
    {
        public List<T> Traverse(Node<T> node)
        {
            var stack = new Stack<Node<T>>();
            var output = new List<T>();
            stack.Push(node);

            while (stack.Count > 0)
            {
                var top = stack.Pop();
                if (top != null)
                {
                    output.Add(top.Value);
                    stack.Push(top.Right);
                    stack.Push(top.Left);
                }
            }

            return output;
        }
    }
}
