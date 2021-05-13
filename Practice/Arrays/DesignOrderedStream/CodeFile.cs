using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.DesignOrderedStream
{
    public class CodeFile
    {
        string[] array;
        int pointer;
        public CodeFile(int n)
        {
            pointer = 1;
            array = new string[n + 1];
        }

        public IList<string> Insert(int idKey, string value)
        {
            array[idKey] = value;
            List<string> output = new List<string>();
            if (pointer == idKey)
            {
                int i = idKey;
                for (; i < array.Length; i++)
                {
                    if (array[i] != null)
                    {
                        output.Add(array[i]);
                    }
                    else
                    {
                        break;
                    }
                }

                pointer = i;
            }

            return output;
        }
    }
}
