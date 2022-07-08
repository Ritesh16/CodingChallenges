using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Sorting._1418.DisplayTableofFoodOrdersinRestaurant
{
    public class CodeFile_Fast
    {
        public IList<IList<string>> DisplayTable(IList<IList<string>> orders)
        {
            var lookup = new Dictionary<int, Dictionary<string, int>>();
            var foodSet = new HashSet<string>();
            var tableSet = new HashSet<int>();

            foreach (var item in orders)
            {
                var table = Int32.Parse(item[1]);
                var food = item[2];

                if (!lookup.ContainsKey(table))
                {
                    lookup.Add(table, new Dictionary<string, int>());
                }

                if (!lookup[table].ContainsKey(food))
                {
                    lookup[table].Add(food, 0);
                }

                lookup[table][food]++;

                foodSet.Add(food);
                tableSet.Add(table);
            }

            var sortedTables = tableSet.OrderBy(t => t).ToList();
            var sortedFood = foodSet.ToList();
            sortedFood.Sort((f1, f2) => string.CompareOrdinal(f1, f2));

            var result = new List<IList<string>>();
            var header = new List<string>();
            header.Add("Table");
            header.AddRange(sortedFood);

            result.Add(header);

            foreach (var table in sortedTables)
            {
                var row = new List<string>();
                row.Add(table.ToString());

                var foodList = lookup[table];
                foreach (var f in sortedFood)
                {
                    if (!foodList.ContainsKey(f))
                    {
                        row.Add("0");
                    }
                    else
                    {
                        row.Add(foodList[f].ToString());
                    }
                }

                result.Add(row);
            }

            return result;
        }
    }
}
