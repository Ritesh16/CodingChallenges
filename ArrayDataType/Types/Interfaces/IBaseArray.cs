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
        int[] Union(int[] array1, int[] array2);
        int[] Intersection(int[] array1, int[] array2);
        int[] Difference(int[] array1, int[] array2);
        void Duplicates();
        int[] ToArray();
    }
}
