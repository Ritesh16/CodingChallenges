namespace ArrayDataType.Types.Interfaces
{
    public interface IArray
    {
        void Add(int value);
        void Insert(int index, int value);
        void Delete(int index);
        int Search(int value);
        int Max();
        int Min();
        double Avg();
        int Sum();
        int[] Reverse(bool newMemory);
        int[] LeftShift();
        int[] RightShift();
    }
}
