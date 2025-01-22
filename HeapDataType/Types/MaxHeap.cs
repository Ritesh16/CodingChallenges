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

            _data[_length] = value;
            HeapifyUp(_length);
            _length++;
        }

        public void Delete()
        {
            if (_length <= 0) return;

            int maxValue = _data[0];
            _data[0] = _data[_length - 1];


            HeapifyDown(0);
            _length--;
        }
        private void Swap(int index1, int index2)
        {
            int temp = _data[index1];
            _data[index1] = _data[index2];
            _data[index2] = temp;
        }
        private void HeapifyUp(int length)
        {
            var i = length;
            while (i != 0 && _data[i] > _data[(i - 1) / 2])
            {
                Swap(i, (i - 1) / 2);
                i = (i - 1) / 2;
            }
        }
        private void HeapifyDown(int index)
        {
            while (true)
            {
                int largest = index;
                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;

                if (leftChild < _size && _data[leftChild] > _data[largest])
                    largest = leftChild;

                if (rightChild < _size && _data[rightChild] > _data[largest])
                    largest = rightChild;

                if (largest == index) break;

                Swap(index, largest);
                index = largest;
            }
        }


        public void Display()
        {
            if (_data == null || _data.Length == 0)
            {
                return;
            }

            for (int i = 0; i < _length; i++)
            {
                Console.Write(_data[i] + " ");
            }

            Console.WriteLine();
        }

        public void Sort()
        {
            for (var i = _data.Length - 1; i > 0; i--)
            {
                Swap(0, i);
                Heapify(_data, i, 0);
            }
        }

        private void Heapify(int[] array, int n, int i)
        {
            int largest = i; // Initialize largest as root
            int left = 2 * i + 1; // Left child index
            int right = 2 * i + 2; // Right child index

            // If left child is larger than root
            if (left < n && array[left] > array[largest])
            {
                largest = left;
            }

            // If right child is larger than largest so far
            if (right < n && array[right] > array[largest])
            {
                largest = right;
            }

            // If largest is not root
            if (largest != i)
            {
                Swap(i, largest);

                // Recursively heapify the affected sub-tree
                Heapify(array, n, largest);
            }

        }
    }
}
