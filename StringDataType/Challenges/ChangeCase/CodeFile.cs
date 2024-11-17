using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDataType.Challenges.ChangeCase
{
    public class CodeFile
    {
        public string ChangeCase(string input)
        {
            var output = new StringBuilder();
            foreach (var c in input)
            {
                var i = (int)c;
                if (i >= 65 && i <= 90)
                {
                    i = i + 32;
                }
                else if (i >= 97 && i <= 122)
                {
                    i = i - 32;
                }

                output.Append((char)i);
            }

            return output.ToString();
        }
    }
}
