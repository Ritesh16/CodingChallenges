using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.RadixSort
{
    public class CodeFile
    {
        public int[] Sort(int[] nums)
        {
            if (nums.Length <= 1) return nums;

            var max = FindMax(nums);
            var counters = new List<int>[10];
            for (int i = 0; i < 10; i++)
            {
                counters[i] = new List<int>();
            }

            for (int i = 1; max / i > 0; i *= 10)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    var num = ((nums[j]) / i) % 10;
                    counters[num].Add(nums[j]);
                }

                // Rewriting
                var index = 0;
                for (int j = 0; j < counters.Length; j++)
                {
                    for(int k = 0; k < counters[j].Count; k++)
                    {
                        nums[index++] = counters[j][k];
                    }
                }

                // Clearing counter
                for (int x = 0; x < 10; x++)
                {
                    counters[x].Clear();
                }
            }



            return nums;
        }
        private int FindMax(int[] nums)
        {
            var max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                }
            }

            return max;
        }
    }
}
