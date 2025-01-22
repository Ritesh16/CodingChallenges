namespace HeapDataType.Types.Interfaces
{
    public interface IHeap
    {
        public int Length { get;}
        void Insert(int value);
        void Delete();
        void Display();

        void Sort();
    }
}
