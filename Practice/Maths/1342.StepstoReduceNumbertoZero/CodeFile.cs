using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Maths._1342.StepstoReduceNumbertoZero
{
    public class CodeFile
    {
        public int NumberOfSteps(int num)
        {
            var steps = 0;
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num--;
                }

                steps++;
            }

            return steps;
        }
    }
}
