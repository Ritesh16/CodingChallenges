using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StacksAndQueues.EvaluateReversePolishNotation
{
    public class CodeFile
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/")
                {
                    var num1 = stack.Pop();
                    var num2 = stack.Pop();

                    var cal = Calculate(num2, num1, tokens[i]);
                    stack.Push(cal);
                }
                else
                {
                    stack.Push(Convert.ToInt32(tokens[i]));
                }
            }

            var result = stack.Pop();
            return result;
        }
        private int Calculate(int num1, int num2, string op)
        {
            int result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    result = num1 / num2;
                    break;
            }

            return result;
        }
    }
}
