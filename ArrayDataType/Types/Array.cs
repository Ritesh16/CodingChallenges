using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDataType.Types
{
    public class Array : IEnumerable<int>
    {
        public int Length { get; set; }

        private int[] _data;
        private int _size = 10;
        private int _index = 0;
        public Array()
        {
            Length = 0;
            _data = new int[_size];
        }

        public int this[int index]
        {
            get
            {
                return _data[index];
            }
            set
            {
                if (index > Length)
                {
                    return;
                }

                _data[index] = value;
            }
        }

        public void Add(int value)
        {
            if (Length == _size)
            {
                Resize();
            }

            _data[_index] = value;
            _index++;
            Length = _index;
        }

        public void Insert(int index, int value)
        {
            if (index > Length)
            {
                return;
            }

            for (int i = Length - 1; i >= index; i--)
            {
                _data[i + 1] = _data[i];
            }

            _data[index] = value;

            Length++;
        }

        public void Delete(int index)
        {
            if (index > Length)
            {
                return;
            }

            for (int i = index; i < Length; i++)
            {
                _data[i] = _data[i + 1];
            }

            Length--;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (var i = 0; i < Length; i++)
            {
                yield return _data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private int[] Resize()
        {
            var newSize = _size * 2;
            var data = new int[newSize];

            for (int i = 0; i < _size; i++)
            {
                data[i] = _data[i];
            }

            _data = data;
            _size = newSize;
            return _data;
        }
    }
}
