using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.PascalTrianglell
{
    public class CodeFile
    {
        public IList<int> GetRow(int rowIndex)
        {
            var output = new List<int>();

            for (int i = 0; i <= rowIndex; i++)
            {
                output.Add(GetNum(rowIndex, i));
            }

            return output;
        }

        public int GetNum(int row, int col)
        {
            if (row == 0 || col == 0 || row == col)
            {
                return 1;
            }

            return GetNum(row - 1, col - 1) + GetNum(row - 1, col);
        }
    }
}
