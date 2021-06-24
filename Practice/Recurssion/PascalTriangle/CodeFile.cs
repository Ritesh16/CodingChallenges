using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.PascalTriangle
{
    class CodeFile
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var output = new List<IList<int>>();
            if (numRows == 0)
            {
                return output;
            }

            var previous = new List<int>();
            previous.Add(1);
            output.Add(previous);

            for (int i = 1; i < numRows; i++)
            {
                var current = new List<int>();

                var c = 0;
                foreach (var item in previous)
                {
                    current.Add(c + item);
                    c = item;
                }

                current.Add(1);
                output.Add(current);
                previous = current;
            }

            return output;
        }
    }
}
