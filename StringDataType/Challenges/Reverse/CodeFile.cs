using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDataType.Challenges.Reverse
{
    public class CodeFile
    {
        public string Reverse(string input)
        {
            var stringBuilder = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(input[i]); 
            }

            return stringBuilder.ToString();
        }
    }
}
