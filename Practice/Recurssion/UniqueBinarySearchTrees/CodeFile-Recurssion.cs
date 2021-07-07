using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Recurssion.UniqueBinarySearchTrees
{
    public class CodeFile_Recurssion
    {
        Dictionary<int, int> dic = new Dictionary<int, int>() { [0] = 1 };
        public int NumTrees(int n)
        {
            if (dic.ContainsKey(n))
            {
                return dic[n];
            }


            var num = 0;
            for (int i = 0; i < n; i++)
            {
                int left = i;
                int right = n - i - 1;

                var leftMost = NumTrees(left);
                var rightMost = NumTrees(right);
                num += leftMost * rightMost;
            }

            dic[n] = num;
            return num;
        }
    }
}
