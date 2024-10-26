using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDataType.Types.Interfaces
{
    public interface IArray
    {
        void Add(int value);
        void Insert(int index, int value);
        void Delete(int index);
        int Search(int value);
    }
}
