using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.HashTables.ShortestWordDistancelll
{
    public class CodeFile
    {
        public int ShortestWordDistance(string[] wordsDict, string word1, string word2)
        {
            Dictionary<string, List<int>> map = new Dictionary<string, List<int>>();

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

            if (word1 == word2)
            {
                return Shortest(word1, map);
            }

            return Shortest(word1, word2, map);
        }

        private int Shortest(string word1, Dictionary<string, List<int>> map)
        {
            var loc1 = map[word1];
            var result = int.MaxValue;
            var i = 1;
            while (i < loc1.Count)
            {
                result = Math.Min(result, Math.Abs(loc1[i] - loc1[i - 1]));
                i++;
            }

            return result;
        }

        private int Shortest(string word1, string word2, Dictionary<string, List<int>> map)
        {
            var l1 = 0;
            var l2 = 0;

            var loc1 = map[word1];
            var loc2 = map[word2];

            var min = int.MaxValue;

            while (l1 < loc1.Count && l2 < loc2.Count)
            {
                min = Math.Min(min, Math.Abs(loc1[l1] - loc2[l2]));
                if (loc1[l1] > loc2[l2])
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
