using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.CheckIfDoubleExist
{
    public class CodeFile
    {
        public bool CheckIfExist(int[] arr)
        {
            var result = false;
            var hashTable = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (hashTable.Contains(arr[i] * 2))
                {
                    return true;
                }

                if(arr[i] %2 ==0 && hashTable.Contains(arr[i] / 2))
                {
                    return true;
                }

                hashTable.Add(arr[i]);
            }

            return result;
        }
    }
}
