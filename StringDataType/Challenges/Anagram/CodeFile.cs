using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDataType.Challenges.Anagram
{
    public class CodeFile
    {
        public bool CheckAnagram(string input1, string input2)
        {
            var bits = new int[128];
            var result = true;

            for (int i = 0; i< input1.Length; i++)
            {
                bits[input1[i]]++;
            }

            for (int i = 0; i < input2.Length; i++)
            {
                bits[input2[i]]--; ;
                if (bits[input2[i]] < 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
