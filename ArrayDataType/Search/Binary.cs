using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDataType.Search
{
    public class Binary
    {
        public int Search(int[] _data, int count, int value)
        {
            var low = 0;
            var high = count - 1;
            var mid = 0;
            var output = -1;

            while (low <= high)
            {
                mid = (high + low) / 2;

                if (_data[mid] < value)
                {
                    low = mid + 1;
                }
                else if (_data[mid] > value)
                {
                    high = mid - 1;
                }
                else
                {
                    output = mid;
                    break;
                }
            }

            return output;
        }
        public int SearchRecursive(int[] data, int count, int value)
        {
            var low = 0;
            var high = count - 1;

            return SearchRecursively(low, high, value, data);
        }
        private int SearchRecursively(int low, int high, int value, int[] data)
        {
            var mid = (high + low) / 2;

            if (low > high) return -1;

            if (data[mid] < value)
            {
                return SearchRecursively(mid + 1, high, value, data);
            }
            else if (data[mid] > value)
            {
                return SearchRecursively(low, high - 1, value, data);
            }
            else
            {
                return mid;
            }
        }
    }
}
