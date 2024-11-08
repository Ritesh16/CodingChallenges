using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDataType.Challenges.FindMissingElement
{
    public class CodeFile
    {
        public void Execute(int[] input)
        {
            if(input.Length == 0)
            {
                return;
            }

            var difference = input[0] - 0;
            for (int i = 0; i < difference; i++)
            {
                if (input[i] - i != difference)
                {
                    while(difference < input[i] - i)
                    {
                        Console.WriteLine($"Missing element : {i + difference}");
                        difference++;
                    }
                }
            }
        }
    }
}
