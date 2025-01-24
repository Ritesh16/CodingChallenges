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

        public void Sort()
        {
            for (var i = _length - 1; i > 0; i--)
            {
                // Swap the root (maximum value) with the last element of the heap
                Swap(0, i);

                // Temporarily decrease the length to ignore the sorted part of the array
                _length--;

                // Heapify down from the root to maintain the max-heap property
                HeapifyDown(0);
            }

            // Reset the length after sorting
            _length = _data.Length;
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
                int leftChild = (2 * index) + 1;
                int rightChild = (2 * index) + 2;

                // Check if the left child exists and is greater than the current node
                if (leftChild < _length && _data[leftChild] > _data[largest])
                {
                    largest = leftChild;
                }

                // Check if the right child exists and is greater than the current node
                if (rightChild < _length && _data[rightChild] > _data[largest])
                {
                    largest = rightChild;
                }

                // If the largest node is the current node, stop heapifying down
                if (largest == index)
                {
                    break;
                }

                // Swap the current node with the largest child
                Swap(index, largest);

                // Update the index to the largest child
                index = largest;
            }
        }
    }
}
