namespace ArrayDataType.Types.Interfaces
{
    public interface IArray : IBaseArray
    {
        void Insert(int index, int value);
        int[] LeftShift();
        int[] RightShift();
    }
}
