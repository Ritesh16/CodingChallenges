namespace QueueDataType.Types.Interfaces
{
    public interface IQueue<T>
    {
        public int Count { get; }
        void Enqueue(T item);
        T Dequeue();
        T Peek();
        T Rear();
        bool IsFull();
        void Reset();
        bool Contains(T item);
        T[] ToArray();
    }
}
