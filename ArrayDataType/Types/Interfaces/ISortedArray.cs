namespace ArrayDataType.Types.Interfaces
{
    internal interface ISortedArray : IBaseArray
    {
        void Insert(int value);
        int[] Merge(int[] array1, int[] array2);
        int[] ToArray();
    }
}
