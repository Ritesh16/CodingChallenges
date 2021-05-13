using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StacksAndQueues.ValidParentheses
{
    public class CodeFile
    {
        public bool IsValid(string s)
        {
            byte[] charArray = Encoding.ASCII.GetBytes(s);
            var stack = new Stack<int>();
            var result = false;
            for (int i = 0; i < charArray.Length; i++)
            {
                var par = charArray[i];

                if (par == 40 || par == 91 || par == 123)
                {
                    stack.Push(par);
                }
                else if (stack.Count == 0)
                {
                    return false;
                }
                else
                {
                    var item = stack.Peek();
                    if (item != par - 2 && item != par - 1)
                    {
                        return false;
                    }

                    stack.Pop();
                }
            }

            if (stack.Count == 0)
            {
                result = true;
            }

            return result;
        }
    }
}
