using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Trie.Implementation
{
    public class Trie
    {

        TrieNode root;
        public Trie()
        {
            root = new TrieNode();
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            var node = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (!node.ContainsKey(word[i]))
                {
                    node.Put(word[i], new TrieNode());
                }

                node = node.Get(word[i]);
            }

            node.SetEnd();
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            var node = SearchPrefix(word);
            return node != null && node.IsEnd();
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            var node = SearchPrefix(prefix);
            return node != null;
        }

        private TrieNode SearchPrefix(string word)
        {
            TrieNode node = root;

            for (int i = 0; i < word.Length; i++)
            {
                if (node.ContainsKey(word[i]))
                {
                    node = node.Get(word[i]);
                }
                else
                {
                    return null;
                }
            }

            return node;
        }
    }

    public class TrieNode
    {
        public TrieNode[] nodes;
        private int R;
        private bool isEnd;
        public TrieNode()
        {
            R = 26;
            nodes = new TrieNode[R];
        }

        public bool ContainsKey(char ch)
        {
            return nodes[ch - 'a'] != null;
        }

        public TrieNode Get(char c)
        {
            return nodes[c - 'a'];
        }

        public void SetEnd()
        {
            isEnd = true;
        }

        public void Put(char c, TrieNode node)
        {
            nodes[c - 'a'] = node;
        }

        public bool IsEnd()
        {
            return isEnd;
        }
    }
}
