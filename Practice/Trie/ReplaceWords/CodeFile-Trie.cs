using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Trie.ReplaceWords
{
    class CodeFile_Trie
    {
        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            var trieNode = new TrieNode();
            for (int i = 0; i < dictionary.Count; i++)
            {
                var node = trieNode;
                for (int j = 0; j < dictionary[i].Length; j++)
                {
                    var c = dictionary[i][j];
                    if (node.nodes[c - 'a'] == null)
                    {
                        node.nodes[c - 'a'] = new TrieNode();
                    }

                    node = node.nodes[c - 'a'];
                }

                node.word = dictionary[i];
            }



            var words = sentence.Split(' ');
            var builder = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                var root = trieNode;
                var word = words[i];

                for (int j = 0; j < word.Length; j++)
                {
                    if (root.nodes[word[j] - 'a'] == null || root.word != null)
                    {
                        break;
                    }

                    root = root.nodes[word[j] - 'a'];
                }

                if (builder.Length > 0)
                    builder.Append(" ");
                builder.Append(root.word != null ? root.word : word);
            }

            return builder.ToString();
        }
    }

    class TrieNode
    {
        public TrieNode[] nodes;
        public string word;
        public TrieNode()
        {
            nodes = new TrieNode[26];
        }
    }
}
