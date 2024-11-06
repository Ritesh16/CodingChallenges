namespace ArrayDataType.Challenges.ArrangeNegativeToLeft
{
    public class CodeFile
    {
        public int[] Execute(int[] input)
        {
            var i = 0;
            var j = input.Length - 1;
            var temp = int.MinValue;

            while (i < j)
            {
                while (input[i] < 0) i++;
                while (input[j] > 0) j--;

                if (i < j)
                {
                    temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                }

            }

            return input;
        }
    }
}
