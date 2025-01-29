using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.CountSort
{
    public class CodeFile
    {
        public int[] Sort(int[] nums)
        {
            if(nums.Length <= 1)
            {
                return nums;
            }   

            var max = FindMax(nums);
            var array = new int[max + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                array[nums[i]]++;
            }

            var index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                while (array[i] > 0)
                {
                    nums[index] = i;
                    array[i]--;
                    index++;
                }
            }

            return nums;
        }

        private int FindMax(int[] nums)
        {
            var max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            return max;
        }
    }
}
