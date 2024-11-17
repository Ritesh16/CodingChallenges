using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDataType.Challenges.Duplicate
{
    public class CodeFile
    {
        public void FindDuplicate(string input)
        {
            int x = 0;
            int h = 0;

            for (int i = 0; i < input.Length; i++)
            {
                x = 1;
                x = x << (input[i] - 97);

                if((x & h) > 0)
                {
                    Console.WriteLine($"{input[i]} is duplicate");
                }
                else
                {
                    h = x | h;
                }
            }
        }
    }
}
