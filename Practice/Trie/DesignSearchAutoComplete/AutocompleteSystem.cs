using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Trie.DesignSearchAutoComplete
{
    public class AutocompleteSystem
    {
        public class AutocompleteNode
        {
            public char c;
            public int times;
            public AutocompleteNode[] children;

            public AutocompleteNode(char c)
            {
                children = new AutocompleteNode[27];
                times = 0;
                this.c = c;
            }
        }

        AutocompleteNode root;
        string search;

        public AutocompleteSystem(string[] sentences, int[] times)
        {
            root = new AutocompleteNode('\0');
            search = "";

            for (int i = 0; i < sentences.Length; i++)
            {
                Insert(sentences[i], times[i]);
            }
        }

        private void Insert(string sentence, int time)
        {
            AutocompleteNode node = root;
            foreach (var c in sentence)
            {
                var index = GetIndex(c);
                if (node.children[index] == null)
                {
                    node.children[index] = new AutocompleteNode(c);
                }

                node = node.children[index];
            }

            node.times += time;
        }

        private int GetIndex(char c)
        {
            return c == ' ' ? 26 : c - 'a';
        }

        private char GetChar(int i)
        {
            return i == 26 ? ' ' : (char)('a' + i);
        }

        public IList<string> Input(char c)
        {
            var output = new List<string>();
            if (c == '#')
            {
                Insert(search, 1);
                search = "";
            }
            else
            {
                search += c;
                var list = Search(search);
                list.Sort((a, b) => a.Item2 == b.Item2 ? a.Item1.CompareTo(b.Item1) : b.Item2.CompareTo(a.Item2));
            
                return list.Select(x => x.Item1).Take(3).ToList();
            }

            return output;
        }

        public List<(string, int)> Search(string sentence)
        {
            var node = root;
            var list = new List<(string, int)>();
            foreach (var c in sentence)
            {
                var index = GetIndex(c);
                if (node.children[index] == null)
                {
                    return list;
                }

                node = node.children[index];
            }

            Populate(node, list, sentence);
            return list;
        }

        private void Populate(AutocompleteNode node, List<(string, int)> list, string sentence)
        {
            if (node.times > 0)
            {
                list.Add((sentence, node.times));
            }

            for (int i = 0; i < 27; i++)
            {
                if (node.children[i] != null)
                {
                    Populate(node.children[i], list, sentence + GetChar(i));
                }
            }
        }
    }

  
}
