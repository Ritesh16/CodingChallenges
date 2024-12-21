using StackDataType.Types.Interfaces;

namespace StackDataType.Types
{
    public class StackUsingArray<T> : IStack<T>
    {
        private T[] _array;
        private int _size = 10;
        public int Count { get; set; }
        public StackUsingArray()
        {
            _array = new T[_size];
            Count = 0;
        }

        public StackUsingArray(int size)
        {
            _size = size;
            _array = new T[_size];
            Count = 0;
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                return default(T);
            }

            return _array[0];
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                return default(T);
            }

            var output = _array[Count - 1];
            _array[Count - 1] = default(T);
            Count--;
            return output;
        }

        public void Push(T value)
        {
            _array[Count++] = value;

            if (_size == Count)
            {
                IncreaseSize();
            }
        }
        public bool IsEmpty()
        {
            var isEmpty = true;
            if (Count > 0)
            {
                isEmpty = false;
            }

            return isEmpty;
        }

        private void IncreaseSize()
        {
            var newSize = _size * 2;
            var newArray = new T[newSize];
            for (var i = 0; i < _size; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
            _size = newSize;
        }
    }
}
