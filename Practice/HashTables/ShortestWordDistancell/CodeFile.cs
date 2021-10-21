using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.HashTables.ShortestWordDistance
{
    public class WordDistance
    {
        Dictionary<string, List<int>> map = new Dictionary<string, List<int>>();
        public WordDistance(string[] wordsDict)
        {
            for (int i = 0; i < wordsDict.Length; i++)
            {
                if (map.ContainsKey(wordsDict[i]))
                {
                    map[wordsDict[i]].Add(i);
                }
                else
                {
                    map.Add(wordsDict[i], new List<int> { i });
                }
            }
        }

        public int Shortest(string word1, string word2)
        {
            var l1 = 0;
            var l2 = 0;

            var loc1 = map[word1];
            var loc2 = map[word2];

            var min = int.MaxValue;

            while (l1 < loc1.Count && l2 < loc2.Count)
            {
                min = Math.Min(min, Math.Abs(loc1[l1] - loc2[l2]));
                if(loc1[l1] > loc2[l2])
                {
                    l2++;
                }
                else
                {
                    l1++;
                }
            }

            return min;
        }
    }
}
