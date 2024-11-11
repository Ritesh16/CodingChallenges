using ArrayDataType.Types.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDataType.Types
{
    public class SortedArray : ISortedArray
    {
        public int Length { get; set; }

        private int[] _data;
        private int _size = 10;
        private int _index = 0;

        public SortedArray()
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
            var index = 0;
            for (int i = Length - 1; i >= 0; i--)
            {
                index = i;
                if (_data[i] <= value)
                {
                    index = i + 1;
                    break;
                }

                _data[i + 1] = _data[i];
            }

            _data[index] = value;

            Length++;
        }

        public int[] Merge(int[] array1, int[] array2)
        {
            var i = 0;
            var j = 0;
            var k = 0;
            var output = new int[array1.Length + array2.Length];

            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] <= array2[j])
                {
                    output[k] = array1[i];
                    i++;
                }
                else
                {
                    output[k] = array2[j];
                    j++;
                }

                k++;
            }

            while (i < array1.Length)
            {
                output[k] = array1[i];
                k++;
                i++;
            }

            while (j < array2.Length)
            {
                output[k] = array2[j];
                k++;
                j++;
            }

            return output;
        }
        public int[] ToArray()
        {
            var output = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                output[i] = _data[i];
            }

            return output;
        }
        public double Avg()
        {
            throw new NotImplementedException();
        }

        public void Delete(int index)
        {
            throw new NotImplementedException();
        }

        public void Insert(int value)
        {
            throw new NotImplementedException();
        }

        public int Max()
        {
            throw new NotImplementedException();
        }

        public int Min()
        {
            throw new NotImplementedException();
        }

        public int[] Reverse(bool newMemory)
        {
            throw new NotImplementedException();
        }

        public int Search(int value)
        {
            throw new NotImplementedException();
        }

        public int Sum()
        {
            throw new NotImplementedException();
        }

        public int[] Union(int[] array1, int[] array2)
        {
            var i = 0;
            var j = 0;
            var k = 0;
            var array = new int[array1.Length + array2.Length];

            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] < array2[j])
                {
                    array[k] = array1[i];
                    i++;
                }
                else if (array1[i] > array2[j])
                {
                    array[k] = array2[j];
                    j++;
                }
                else
                {
                    array[k] = array1[i];
                    i++;
                    j++;
                }

                k++;
            }

            while (i < array1.Length)
            {
                array[k] = array1[i];
                i++;
                k++;
            }

            while (j < array2.Length)
            {
                array[k] = array2[j];
                j++;
                k++;
            }

            var output = new int[k];
            System.Array.Copy(array, output, k);

            return output;
        }

        public int[] Intersection(int[] array1, int[] array2)
        {
            var i = 0;
            var j = 0;
            var k = 0;
            var array = new int[array1.Length + array2.Length];

            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] == array2[j])
                {
                    array[k] = array1[i];
                    k++;
                }

                i++;
                j++;
            }


            var output = new int[k];
            System.Array.Copy(array, output, k);

            return output;
        }

        public int[] Difference(int[] array1, int[] array2)
        {
            var i = 0;
            var j = 0;
            var k = 0;
            var array = new int[array1.Length + array2.Length];

            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] < array2[j])
                {
                    array[k] = array1[i];
                    k++;
                    i++;
                }
                else if (array1[i] > array2[j])
                {
                    j++;
                }
                else
                {
                    i++;
                    j++;
                }
            }


            var output = new int[k];
            System.Array.Copy(array, output, k);

            return output;
        }

        public void Duplicates()
        {
            var j = 0;
            for (int i = 0; i < Length - 1; i++)
            {
                if (_data[i] == _data[i + 1])
                {
                    j = i + 1;
                    while (j < Length && _data[j] == _data[i])
                    {
                        j++;
                    }

                    Console.WriteLine($"{_data[i]} has occurred {j-i} times.");

                    i = j + 1;
                }
            }
        }
    }
}
