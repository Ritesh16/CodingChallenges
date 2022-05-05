using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Sorting._1859.SortingtheSentence
{
    public class CodeFile_SingleLoop
    {
        public string SortSentence(string s)
        {
            var inputArray = s.Split(' ');
            var outputArray = new string[inputArray.Length];

            foreach (var i in inputArray)
            {
                if (int.TryParse(i[i.Length - 1].ToString(), out int ind))
                {
                    if (ind >= 1)
                    {
                        outputArray[ind - 1] = i.Substring(0, i.Length - 1);
                    }
                }
            }


            var output = string.Join(' ', outputArray);


            return output;
        }
    }
}
