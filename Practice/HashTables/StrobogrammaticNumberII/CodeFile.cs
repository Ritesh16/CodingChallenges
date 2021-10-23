using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.HashTables.StrobogrammaticNumberII
{
    public class CodeFile
    {
        public IList<string> FindStrobogrammatic(int n)
        {
            var map = new Dictionary<int, List<string>>();
            map.Add(0, new List<string>() { "" });
            map.Add(1, new List<string>() { "0", "1", "8" });

            if (n == 0) return map[0];
            if (n == 0) return map[1];

            for (int i = 2; i <= n; i++)
            {
                var temp = map[i - 2];
                var list = new List<string>();
                foreach (var item in temp)
                {
                    if (i != n)
                    {
                        list.Add("0" + item + "0"); 
                    }

                    list.Add("1" + item + "1");
                    list.Add("8" + item + "8");
                    list.Add("9" + item + "6");
                    list.Add("6" + item + "9");
                }

                map.Remove(i - 2);
                map.Add(i, list);
            }

            return map[n];
        }
    }
}
