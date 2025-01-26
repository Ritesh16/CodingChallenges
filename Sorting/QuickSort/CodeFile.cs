namespace Sorting.QuickSort
{
    public class CodeFile
    {
        public int[] Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                var pivot = Partition(array, low, high);

                Sort(array, low, pivot - 1);
                Sort(array, pivot + 1, high);
            }

            return array;
        }

        private int Partition(int[] array, int low, int high)
        {
            var pivot = array[high];
            var i = low - 1;

            for(var j = low; j< high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);
            return i + 1;

        }

        private void Swap(int[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
