using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDataType.Challenges.ValidParentheses
{
    public class CodeFile
    {
        public bool IsValid(string s)
        {
            var result = false;
            if (string.IsNullOrEmpty(s))
            {
                return result;
            }

            var stack = new Stack<char>();
            foreach (var c in s)
            {
                var num = (int)c;
                if (num == 91 || num == 123 || num == 40)
                {
                    stack.Push(c);
                }
                else 
                {
                    if(stack.Count == 0)
                    {
                        return result;
                    }

                    if ((num == 41 & stack.Peek() == 40) ||
                        (num == 93 & stack.Peek() == 91) ||
                        (num == 125 & stack.Peek() == 123))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                
            }

            if(stack.Count == 0)
            {
                result = true;
            }

            return result;
        }
    }
}
