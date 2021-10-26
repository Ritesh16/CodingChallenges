using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.HashTables.GroupShiftedStrings
{
    class CodeFile
    {
        public IList<IList<string>> GroupStrings(string[] strings)
        {
            var map = new Dictionary<string, List<string>>();

            foreach (var str in strings)
            {
                var sb = new StringBuilder();
                for (int i = 1; i < str.Length; i++)
                {
                    sb.Append((str[i] - str[i - 1] + 26) % 26 + " ");
                }

                var key = sb.ToString();

                if (map.ContainsKey(key))
                {
                    map[key].Add(str);
                }
                else
                {
                    map[key] = new List<string>() { str };
                }
            }

            var output = new List<IList<string>>(map.Select(d => d.Value));

            return output;
        }
    }
}
