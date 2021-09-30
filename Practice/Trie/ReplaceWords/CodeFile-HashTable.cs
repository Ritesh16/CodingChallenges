using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Trie.ReplaceWords
{
    class CodeFile_HashTable
    {
        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            var hashSet = new HashSet<string>();
            foreach (var item in dictionary)
            {
                hashSet.Add(item);
            }

            var builder = new StringBuilder();
            var words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                var prefix = string.Empty;
                for (int j = 1; j <= words[i].Length; j++)
                {
                    prefix = words[i].Substring(0, j);
                    if (hashSet.Contains(prefix))
                    {
                        break;
                    }
                }

                if (builder.Length > 0) builder.Append(" ");

                builder.Append(prefix);

            }

            return builder.ToString();
        }
    }
}
