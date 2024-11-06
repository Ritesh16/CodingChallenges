namespace ArrayDataType.Types.Interfaces
{
    public interface IBaseArray
    {
        void Add(int value);
        void Delete(int index);
        int Search(int value);
        int Max();
        int Min();
        double Avg();
        int Sum();
        int[] Reverse(bool newMemory);
    }
}
