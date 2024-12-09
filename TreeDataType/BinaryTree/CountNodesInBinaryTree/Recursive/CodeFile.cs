namespace TreeDataType.BinaryTree.CountNodesInBinaryTree.Recursive
{
    public class CodeFile<T>
    {
        public int Count(Node<T> root)
        {
            if (root != null)
            {
                return Count(root.Left) + Count(root.Right) + 1;
            }

            return 0;
        }
    }
}
