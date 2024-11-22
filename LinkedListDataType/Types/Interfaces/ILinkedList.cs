namespace LinkedListDataType.Types.Interfaces
{
    public interface ILinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Length { get; set; }
        public Node<T> Add(T value);
        public void Display();
        public void Display_Recursively(Node<T> node);
        public void Reverse(Node<T> node);
        public int Sum();
        public int Count();
        public T Max();
        public T Min();
    }
}
