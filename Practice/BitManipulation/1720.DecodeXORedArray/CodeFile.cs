using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.BitManipulation._1720.DecodeXORedArray
{
    public class CodeFile
    {
        public int[] Decode(int[] encoded, int first)
        {
            var result = new int[encoded.Length + 1];
            result[0] = first;

            for (int i = 1; i <= encoded.Length; i++)
            {
                result[i] = result[i - 1] ^ encoded[i - 1];
            }

            return result;
        }
    }
}
