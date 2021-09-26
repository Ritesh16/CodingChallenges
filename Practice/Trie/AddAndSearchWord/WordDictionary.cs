using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Trie.AddAndSearchWord
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> children;
        public bool word;
        public TrieNode()
        {
            children = new Dictionary<char, TrieNode>();
        }
    }
    public class WordDictionary
    {
        TrieNode trie;
        public WordDictionary()
        {
            trie = new TrieNode();
        }

        public void AddWord(string word)
        {
            var node = trie;
            for (int i = 0; i < word.Length; i++)
            {
                if (!node.children.ContainsKey(word[i]))
                {
                    node.children.Add(word[i], new TrieNode());
                }

                node = node.children[word[i]];
            }

            node.word = true;
        }

        public bool Search(string word)
        {
            return SearchInNode(word, trie);
        }

        private bool SearchInNode(string word, TrieNode node)
        {
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];

                if (!node.children.ContainsKey(c))
                {
                    if (c == '.')
                    {
                        foreach (var key in node.children.Keys)
                        {
                            var child = node.children[key];
                            if (SearchInNode(word.Substring(i + 1), child))
                            {
                                return true;
                            }
                        }
                    }

                    return false;
                }
                else
                {
                    node = node.children[c];
                }
            }

            return node.word;
        }
    }
}
