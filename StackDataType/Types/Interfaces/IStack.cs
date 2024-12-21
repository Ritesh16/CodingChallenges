namespace StackDataType.Types.Interfaces
{
    public interface IStack<T>
    {
        public int Count { get; set; }
        void Push(T value);
        T Pop();
        T Peek();
        bool IsEmpty();
    }
}
