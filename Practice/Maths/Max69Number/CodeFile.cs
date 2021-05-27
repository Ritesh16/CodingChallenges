using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Maths.Max69Number
{
    class CodeFile
    {
        public int Maximum69Number(int num)
        {
            var charArray = num.ToString().ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
                if (charArray[i] == '6')
                {
                    charArray[i] = '9';
                    break;
                }

            return int.Parse(new string(charArray));
        }
    }
}
