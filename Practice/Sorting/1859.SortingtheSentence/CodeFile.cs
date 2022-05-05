using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._1859.SortingtheSentence
{
    public class CodeFile
    {
        public string SortSentence(string s)
        {
            var inputArray = s.Split(' ');
            var outputArray = new string[inputArray.Length];

            foreach (var item in inputArray)
            {
                foreach (var c in item)
                {
                    if (char.IsDigit(c))
                    {
                        var index = Convert.ToInt16(char.GetNumericValue(c));
                        var word = item.Substring(0, item.Length - 1);
                        outputArray[index - 1] = word;
                    }
                }
            }


            var output = string.Join(' ', outputArray);


            return output;
        }
    }
}
