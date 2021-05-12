using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StacksAndQueues.MinStack
{
    public class MinStack
    {
        /** initialize your data structure here. */
        Stack<int> stack;
        Stack<int[]> minStack;
        public MinStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int[]>();
        }

        public void Push(int val)
        {
            stack.Push(val);

            if (minStack.Count == 0 || minStack.Peek()[0] > val)
            {
                var array = new int[] { val, 1 };
                minStack.Push(array);
            }
            else if (minStack.Peek()[0] == val)
            {
                minStack.Peek()[1]++;
            }

        }

        public void Pop()
        {
            var top = stack.Peek();
            var minTop = minStack.Peek();

            if (top == minTop[0])
            {
                minTop[1]--;
                if (minTop[1] == 0)
                {
                    minStack.Pop();
                }
            }

            stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return minStack.Peek()[0];
        }
    }
}
