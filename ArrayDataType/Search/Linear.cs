using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDataType.Search
{
    public class Linear
    {
        public int Search(int[] _data, int count, int value)
        {
            var output = -1;

            for (int i = 0; i <= count-1; i++)
            {
                if(value == _data[i])
                {
                    output = i;
                    break;
                }
            }

            return output;
        }
    }
}
