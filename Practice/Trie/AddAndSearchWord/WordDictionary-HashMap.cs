using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Trie.AddAndSearchWord
{
    public class WordDictionary_HashMap
    {
        Dictionary<int, HashSet<string>> dictionary;

        public WordDictionary_HashMap()
        {
            dictionary = new Dictionary<int, HashSet<string>>();
        }

        public void AddWord(string word)
        {
            var length = word.Length;
            if (!dictionary.TryGetValue(length, out var words))
            {
                words = new HashSet<string>();
                words.Add(word);
                dictionary.Add(length, words);
            }
            else
            {
                words.Add(word);
            }
        }

        public bool Search(string word)
        {
            var length = word.Length;
            if (dictionary.TryGetValue(length, out var words))
            {
                foreach (var w in words)
                {
                    var found = true;
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] != '.' && word[i] != w[i])
                        {
                            found = false;
                            break;
                        }
                    }

                    if (found)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
