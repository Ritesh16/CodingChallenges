using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.BucketSort
{
    public class CodeFile
    {
        public int[] Sort(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums;
            }

            var max = FindMax(nums);
            List<int>[] buckets = new List<int>[max + 1];
            for (int i = 0; i <= max; i++)
            {
                buckets[i] = new List<int>();
            }

            var index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                buckets[nums[i]].Add(nums[i]);
            }

            for (int i = 0; i <= max; i++)
            {
                InsertionSort(buckets[i]);
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    nums[index] = buckets[i][j];
                    index++;
                }
            }

            return nums;
        }

        public void InsertionSort(List<int> bucket)
        {
            for (int i = 1; i < bucket.Count; ++i)
            {
                int key = bucket[i];
                int j = i - 1;
                while (j >= 0 && bucket[j] > key)
                {
                    bucket[j + 1] = bucket[j];
                    j--;
                }
                bucket[j + 1] = key;
            }
        }

        private int FindMax(int[] nums)
        {
            var max = nums[0];
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
