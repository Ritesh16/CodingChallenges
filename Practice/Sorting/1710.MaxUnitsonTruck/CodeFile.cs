using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._1710.MaxUnitsonTruck
{
    public class CodeFile
    {
        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {

            Array.Sort(boxTypes, (a, b) => { return b[1] - a[1]; });

            int count = 0;

            foreach (var type in boxTypes)
            {
                int num = Math.Min(type[0], truckSize);
                count += num * type[1];

                if (truckSize < num)
                    break;

                truckSize -= num;
            }

            return count;
        }
    }
}
