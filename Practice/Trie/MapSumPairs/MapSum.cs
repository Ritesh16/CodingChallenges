using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Trie.MapSumPairs
{
    public class MapSum
    {
        TrieNode root;
        public MapSum()
        {
            root = new TrieNode();
        }

        public void Insert(string key, int val)
        {
            var node = root;
            for (int i = 0; i < key.Length; i++)
            {
                if (!node.Next.ContainsKey(key[i]))
                {
                    node.Next.Add(key[i], new TrieNode());
                }

                node = node.Next[key[i]];
            }

            node.Value = val;
        }

        public int Sum(string prefix)
        {
            TrieNode node = root;

            for (int i = 0; i < prefix.Length; i++)
            {
                if (!node.Next.ContainsKey(prefix[i]))
                {
                    return 0;
                }

                node = node.Next[prefix[i]];
            }

            return Sum(node);
        }

        private int Sum(TrieNode node)
        {
            int sum = node.Value;

            foreach (var item in node.Next.Keys)
            {
                sum += Sum(node.Next[item]);
            }

            return sum;
        }
    }

    public class TrieNode
    {
        public int Value;
        public Dictionary<char, TrieNode> Next { get; set; }

        public TrieNode(int val)
        {
            Value = val;
            Next = new Dictionary<char, TrieNode>();
        }

        public TrieNode() : this(0)
        {

        }
    }
}
