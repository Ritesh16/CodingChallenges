using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays._682.BaseballGame
{
    public class CodeFile
    {
        public int CalPoints(string[] ops)
        {
            var stack = new Stack<int>();

            foreach (var item in ops)
            {
                if (item == "C")
                {
                    stack.Pop();
                }
                else if (item == "D")
                {
                    var last = Convert.ToInt32(stack.Peek());
                    last = last * 2;
                    stack.Push(last);
                }
                else if (item == "+")
                {
                    var num1 = stack.Pop();
                    var num2 = stack.Pop();
                    var num3 = num1 + num2;

                    stack.Push(num2);
                    stack.Push(num1);
                    stack.Push(num3);

                }
                else
                {
                    var num = Convert.ToInt32(item);
                    stack.Push(num);
                }
            }


            return stack.Sum();
        }
    }
}
