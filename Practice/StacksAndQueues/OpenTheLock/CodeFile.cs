using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.StacksAndQueues.OpenTheLock
{
    public class CodeFile
    {
        public int OpenLock(string[] d, string t)
        {
            var deadEnds = new HashSet<string>(d);
            if (deadEnds.Contains("0000") || deadEnds.Contains(t))
                return -1;


            var visited = new HashSet<string>();
            var queue = new Queue<string>();
            queue.Enqueue("0000");
            visited.Add("0000");
            var level = 0;

            while (queue.Any())
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var current = queue.Dequeue();
                    if (current.Equals(t))
                        return level;
                    foreach (var item in GetNeighbors(current))
                    {
                        if (!deadEnds.Contains(item) && !visited.Contains(item))
                        {
                            queue.Enqueue(item);
                            visited.Add(item);
                        }
                    }
                }

                level++;
            }

            return -1;
        }

        private IEnumerable<string> GetNeighbors(string current)
        {
            var result = new List<string>();
            for (int i = 0; i < current.Length; i++)
            {
                var charArray1 = current.ToArray();
                charArray1[i] = charArray1[i] == '9' ? '0' : (char)((int)charArray1[i] + 1);
                result.Add(new string(charArray1));

                var charArray2 = current.ToArray();
                charArray2[i] = charArray2[i] == '0' ? '9' : (char)((int)charArray2[i] - 1);
                result.Add(new string(charArray2));
            }

            return result;
        }
    }
}
