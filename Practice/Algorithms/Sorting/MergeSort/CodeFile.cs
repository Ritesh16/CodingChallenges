namespace Practice.Algorithms.Sorting.MergeSort
{
    public class CodeFile
    {
        public int[] SortArray(int[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }


        private int[] MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                var mid = (right - left) / 2 + left;

                var array1 = MergeSort(array, left, mid);
                var array2 = MergeSort(array, mid + 1, right);

                return Merge(array1, array2);
            }

            return new int[] { array[left] };
        }

        private int[] Merge(int[] array1, int[] array2)
        {
            var array = new int[array1.Length + array2.Length];
            var i = 0;
            var j = 0;

            var index = 0;
            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] < array2[j])
                {
                    array[index] = array1[i];
                    i++;
                }
                else
                {
                    array[index] = array2[j];
                    j++;
                }
                index++;
            }

            while (i < array1.Length)
            {
                array[index] = array1[i];
                i++;
                index++;
            }

            while (j < array2.Length)
            {
                array[index] = array2[j];
                j++;
                index++;
            }


            return array;
        }
    }
}
