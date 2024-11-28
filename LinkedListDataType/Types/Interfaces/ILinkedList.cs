namespace LinkedListDataType.Types.Interfaces
{
    public interface ILinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Length { get; set; }
        public Node<T> Add(T value);
        public Node<T> AddFirst(T value);
        public Node<T> AddLast(T value);
        public void Display();
        public void Display_Recursively(Node<T> node);
        public void PrintReverse(Node<T> node);
        public int Sum();
        public int Count();
        public T Max();
        public T Min();
        public Node<T> Search(T value);
        public Node<T> Insert(int index, T value);
        public Node<T> Reverse();
        public void Reverse_Recursively(Node<T> first, Node<T> second);
        public Node<T> Delete(T value);
        public bool HasLoop(Node<T> node);
        public Node<T> Merge(Node<T> first, Node<T> second);

    }
}
