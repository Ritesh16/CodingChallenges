using HeapDataType.Types.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapDataType.Types
{
    public class MaxHeap : IHeap
    {
        private int[] _data;
        private int _length;
        private int _size;
        public int Length
        {
            get
            {
                return _length;
            }
        }
        public MaxHeap(int size)
        {
            _data = new int[size];
            _length = 0;
            _size = size;
        }
        public void Insert(int value)
        {
            if (_length == _size)
            {
                return;
            }

            var i = _length;
            _data[i] = value;
            _length++;

            while (i != 0 && _data[i] > _data[(i - 1) / 2])
            {
                Swap(i, (i - 1) / 2);
                i = (i - 1) / 2;
            }
        }

        private void Swap(int index1, int index2)
        {
            int temp = _data[index1];
            _data[index1] = _data[index2];
            _data[index2] = temp;
        }
        //private int Parent(int key)
        //{
        //    return (key - 1) / 2;
        //}
    }
}
