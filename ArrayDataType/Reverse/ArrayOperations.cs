namespace ArrayDataType.Reverse
{
    public class ArrayOperations
    {
        public int[] ReverseWithNewArray(int[] input, int length)
        {
            var output = new int[input.Length];
            var j = length - 1;
            var i = 0;
            while (i < length)
            {
                output[j] = input[i];
                i++;
                j--;
            }

            return output;
        }

        public int[] ReverseWithoutNewArray(int[] input, int length)
        {
            var frontIndex = 0;
            var backIndex = length - 1;
            var temp = int.MaxValue;

            while (frontIndex < backIndex)
            {
                temp = input[frontIndex];
                input[frontIndex] = input[backIndex];
                input[backIndex] = temp;
                frontIndex++;
                backIndex--;
            }

            return input;
        }
    }
}
