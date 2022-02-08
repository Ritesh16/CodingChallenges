using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.HashTables._1817FindingUsersActiveMinutes
{
    public class CodeFile
    {
        public int[] FindingUsersActiveMinutes(int[][] logs, int k)
        {
            var result = new int[k];
            var map = new Dictionary<int, HashSet<int>>();
            for (int i = 0; i < logs.Length; i++)
            {
                if (map.ContainsKey(logs[i][0]))
                {
                    map[logs[i][0]].Add(logs[i][1]);
                }
                else
                {
                    var hashSet = new HashSet<int>();
                    hashSet.Add(logs[i][1]);
                    map.Add(logs[i][0], hashSet);
                }
            }

            foreach (var elem in map)
                result[elem.Value.Count - 1]++; // index = hashSet.Count - 1
            return result;
        }
    }
}
