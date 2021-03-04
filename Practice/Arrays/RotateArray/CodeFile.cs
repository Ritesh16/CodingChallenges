using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.RotateArray
{
    public class CodeFile
    {
        public void Rotate(int[] nums, int k)
        {
            var output = WithoutExtraSpace(nums, k);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }

        public int[] WithoutExtraSpace(int[] nums, int k)
        {
            var last = 0;
            while (k > 0)
            {
                var length = nums.Length - 1;
                last = nums[length];
                while (length > 0)
                {
                    nums[length] = nums[length - 1];
                    length--;
                }

                nums[0] = last;

                k--;
            }

            return nums;
        }

        public int[] ExtraSpace(int[] nums, int k)
        {
            var output = new int[nums.Length];
            var pointer = 0;

            for (int i = k+1; i < nums.Length; i++)
            {
                output[pointer] = nums[i];
                pointer++;
            }

            for (int i = 0; i <= k; i++)
            {
                output[pointer] = nums[i];
                pointer++;
            }

            return output;
        }
    }
}
