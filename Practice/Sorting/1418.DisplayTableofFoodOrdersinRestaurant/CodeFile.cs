using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Sorting._1418.DisplayTableofFoodOrdersinRestaurant
{
    public class CodeFile
    {
        public IList<IList<string>> DisplayTable(IList<IList<string>> orders)
        {
            var lookup = orders.GroupBy(i => i[1], i => i[2])
                           .ToDictionary(g => Int32.Parse(g.Key), g => g.GroupBy(k => k).ToDictionary(g2 => g2.Key, g2 => g2.Count()));

            var header = new List<string>();
            header.Add("Table");
            var dishes = orders.GroupBy(g => g[2], g => g[2]).Select(grp => grp.First()).OrderBy(x => x, StringComparer.Ordinal).ToList();
            header.AddRange(dishes);

            var result = new List<IList<string>>();
            result.Add(header);

            var tables = lookup.Keys.OrderBy(x => x).ToList();

            foreach (var t in tables)
            {
                var row = new List<string>();
                row.Add(t.ToString());
                foreach (var d in dishes)
                {
                    row.Add(lookup[t].ContainsKey(d) ? lookup[t][d].ToString() : "0");
                }
                result.Add(row);
            }
            return result;
        }
    }
}
