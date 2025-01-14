namespace TreeDataType.AVL
{
    public class AVLTreeNode<T> where T : IComparable<T>
    {
        public T Value;
        public AVLTreeNode<T> Left;
        public AVLTreeNode<T> Right;
        public int Height;

        public AVLTreeNode(T value)
        {
            Value = value;
            Height = 1;
        }
    }
}
