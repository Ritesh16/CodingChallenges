using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StacksAndQueues.PerfectSquares
{
    public class CodeFile
    {
        public int NumSquares(int n)
        {
            if (n < 4)
            {
                return n;
            }

            var squares = new List<int>();
            for (int i = 1; i < n; i++)
            {
                squares.Add(i * i);
            }

            int level = 0;
            var queue = new HashSet<int>();
            queue.Add(n);

            while (queue.Count > 0)
            {
                level++;
                var newQueue = new HashSet<int>();
                foreach (var number in queue)
                {
                    foreach (var square in squares)
                    {
                        if (number == square)
                        {
                            return level;
                        }
                        else if (number < square)
                        {
                            break;
                        }
                        else
                        {
                            newQueue.Add(number - square);
                        }
                    }
                }

                queue = newQueue;
            }

            return level;
        }
    }
}
