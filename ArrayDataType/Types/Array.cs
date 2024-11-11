using ArrayDataType.Reverse;
using ArrayDataType.Search;
using ArrayDataType.Types.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDataType.Types
{
    public class Array : IEnumerable<int>, IArray
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
        public int Search(int value)
        {
            if (_data.Length <= 20)
            {
                var linearSearch = new Linear();
                return linearSearch.Search(_data, Length, value);
            }
            else
            {
                var binarySearch = new Binary();
                return binarySearch.Search(_data, Length, value);
            }
        }
        public int Max()
        {
            var max = int.MinValue;
            for (int i = 0; i < Length; i++)
            {
                if (_data[i] > max)
                    max = _data[i];
            }

            return max;
        }
        public int Min()
        {
            var max = int.MaxValue;
            for (int i = 0; i < Length; i++)
            {
                if (_data[i] < max)
                    max = _data[i];
            }

            return max;
        }
        public double Avg()
        {
            var sum = Sum();
            return sum / Length;
        }
        public int Sum()
        {
            var output = 0;
            for (int i = 0; i < Length; i++)
            {
                output += _data[i];
            }

            return output;
        }
        public int[] Reverse(bool newMemory = false)
        {
            var output = this._data;
            var arrayOperations = new ArrayOperations();
            if (newMemory)
            {
                output = arrayOperations.ReverseWithoutNewArray(this._data, Length);
            }
            else
            {
                output = arrayOperations.ReverseWithNewArray(this._data, Length);
            }

            return output;
        }

        // we can do this using new array
        public int[] LeftShift()
        {
            var first = this._data[0];

            for (int i = 1; i < Length; i++)
            {
                this._data[i - 1] = this._data[i];
            }

            this._data[Length - 1] = first;
            return this._data;
        }

        public int[] RightShift()
        {
            var last = this._data[Length - 1];

            for (int i = Length - 2; i >= 0; i--)
            {
                this._data[i + 1] = this._data[i];
            }

            this._data[0] = last;
            return this._data;
        }
        public int[] Union(int[] array1, int[] array2)
        {
            var array = new int[array1.Length + array2.Length];

            // Copy element from first array
            for (int i = 0; i < array1.Length; i++)
            {
                array[i] = array1[i];
            }

            var k = array1.Length;

            for (int i = 0; i < array2.Length; i++)
            {
                var isDuplicate = false;
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array[j] == array2[i])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if(!isDuplicate)
                {
                    array[k] = array2[i];
                    k++;
                }

            }

            var output = new int[k];
            System.Array.Copy(array, output, k);
            
            return output;

        }

        public int[] Intersection(int[] array1, int[] array2)
        {
            var array = new int[array1.Length + array2.Length];
            var k = 0;

            for (int i = 0; i < array2.Length; i++)
            {
                var isDuplicate = false;
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array1[j] == array2[i])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (isDuplicate)
                {
                    array[k] = array2[i];
                    k++;
                }

            }

            var output = new int[k];
            System.Array.Copy(array, output, k);

            return output;
        }

        public int[] Difference(int[] array1, int[] array2)
        {
            var array = new int[array1.Length + array2.Length];
            var k = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                var isDuplicate = false;
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    array[k] = array1[i];
                    k++;
                }

            }

            var output = new int[k];
            System.Array.Copy(array, output, k);

            return output;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (var i = 0; i < Length; i++)
            {
                yield return _data[i];
            }
        }


        // Private methods
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

        private int[] Initialize(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.MaxValue;
            }

            return array;
        }

        public int[] ToArray()
        {
            return _data;
        }

        public void Duplicates()
        {
            var map = new Dictionary<int, int>();
            for(int i = 0;i < Length;i++)
            {
                if(map.ContainsKey(_data[i]))
                {
                    map[_data[i]]++;
                }
                else
                {
                    map[_data[i]] = 1;
                }
            }

            var duplicates = map.Where(x => x.Value > 1);
            foreach(var duplicate in duplicates)
            {
                Console.WriteLine($"{duplicate.Key} has {duplicate.Value} occurrences.");
            }
        }
    }
}
