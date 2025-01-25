namespace Sorting.SelectionSort
{
    public class CodeFile
    {
        public int[] Sort(int[] nums)
        {
            var temp = 0;
            var smallest = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                smallest = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[smallest])
                        smallest = j;
                }

                temp = nums[smallest];
                nums[smallest] = nums[i];
                nums[i] = temp;
            }

            return nums;
        }
    }
}
