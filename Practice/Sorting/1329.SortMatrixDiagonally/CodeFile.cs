using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._1329.SortMatrixDiagonally
{
    public class CodeFile
    {
        public int[][] DiagonalSort(int[][] mat)
        {
            int rows = mat.Length;
            int cols = mat[0].Length;
            if (rows == 0 || cols == 0)
            {
                return null;
            }

            var r = 0;
            var c = 0;


            var pointer = 0;

            while (c < cols)
            {
                var r1 = 0;
                var c1 = c;
                var list = new List<int>();
                while (c1 < cols && r1 < rows)
                {
                    list.Add(mat[r1][c1]);
                    r1++;
                    c1++;
                }

                list.Sort();

                r1 = 0;
                c1 = c;

                while (c1 < cols && r1 < rows)
                {
                    mat[r1][c1] = list[pointer];
                    pointer++;
                    r1++;
                    c1++;
                }

                pointer = 0;
                c++;
            }

            r = 1;
            pointer = 0;

            while (r < rows)
            {
                var r1 = r;
                var c1 = 0;
                var list = new List<int>();
                while (r1 < rows && c1 < cols)
                {
                    list.Add(mat[r1][c1]);
                    r1++;
                    c1++;
                }

                list.Sort();
                c1 = 0;
                r1 = r;

                while (r1 < rows && c1 < cols)
                {
                    mat[r1][c1] = list[pointer];
                    pointer++;
                    r1++;
                    c1++;
                }

                pointer = 0;
                r++;
            }

            return mat;
        }
    }
}
