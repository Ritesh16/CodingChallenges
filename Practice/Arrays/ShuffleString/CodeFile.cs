using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.ShuffleString
{
    internal class CodeFile
    {
        public string RestoreString(string s, int[] indices)
        {
            var array = new char[indices.Length];
            for (int i = 0; i < indices.Length; i++)
            {
                array[indices[i]] = s[i];
            }

            return new String(array);
        }
    }
}
