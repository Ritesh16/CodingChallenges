using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDataType.Challenges.Compare
{
    public class CodeFile
    {
        // 0 = equal
        // 1 = input1
        // -1 = input2
        public int Compare(string input1, string input2)
        {
            var first = 0;
            var second = 0;
            var result = 0;

            while (first < input1.Length && second < input2.Length)
            {
                var asci1 = (int)input1[first];
                var asci2 = (int)input2[second];
                if (asci1 == asci2)
                {
                    first++;
                    second++;
                }
                else if (asci1 > asci2)
                {
                    result = 1;
                    break;
                }
                else
                {
                    result = -1;
                    break;
                }

            }

            return result;
        }
    }
}
