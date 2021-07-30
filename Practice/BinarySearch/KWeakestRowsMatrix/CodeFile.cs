using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BinarySearch.KWeakestRowsMatrix
{
    class CodeFile
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            return Enumerable.Range(0, mat.Length).OrderBy(x => mat[x].Sum()).Take(k).ToArray();
        }
    }
}
