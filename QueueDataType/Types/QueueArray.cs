using QueueDataType.Types.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QueueDataType.Types
{
    public class QueueArray<T> : IQueue<T>
    {
        private int _count;
        private T[] _array;
        private int _size;
        private int _front;
        private int _back;
        public int Count => _count;
        public QueueArray()
        {
            _size = 10;
            Reset();
        }
        public QueueArray(int size)
        {
            _size = size;
            Reset();
        }
        public void Reset()
        {
            _array = new T[_size];
            _count = 0;
        }

        public bool Contains(T item)
        {
            if(_count == 0)
            {
                return false;
            }

            var i = 0;
            var output = false;
            while (i < _size)
            {
                if (_array[i].Equals(item))
                {
                    output = true;
                    break;
                }

                i++;
            }

            return output;
        }

        public T Dequeue()
        {
            if (_count == 0)
            {
                Console.WriteLine("Queue is empty.");
                return default(T);
            }

            if (_front >= _size - 1)
            {
                _front = 0;
            }

            var val = _array[_front];
            _array[_front] = default(T);
            _front++;
            _count--;
            return val;
        }

        public void Enqueue(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("Max size of queue has reached.");
                return;
            }

            if (_back > _size - 1)
            {
                _back = 0;
            }

            _array[_back++] = item;
            _count++;
        }

        public bool IsFull()
        {
            return _count == _size;
        }

        public T Peek()
        {
            if (_count == 0)
            {
                Console.WriteLine("Queue is empty.");
                return default(T);
            }

            return _array[_front];
        }

        public T Rear()
        {
            if (_count == 0)
            {
                Console.WriteLine("Queue is empty.");
                return default(T);
            }

            return _array[_back];
        }

        public T[] ToArray()
        {
            var output = new T[_count];

            var front = _front;
            var back = _back;
            var i = 0;

            if(front < back)
            {
                while (front < back)
                {
                    output[i] = _array[front];
                    front++;
                    i++;
                }
            }
            else
            {
                while (front < _size)
                {
                    output[i] = _array[front];
                    front++;
                    i++;
                }

                var startFromBegining = 0;
                while (startFromBegining < back)
                {
                    output[i] = _array[startFromBegining];
                    startFromBegining++;
                    i++;
                }

            }

            return output;
        }
    }
}
