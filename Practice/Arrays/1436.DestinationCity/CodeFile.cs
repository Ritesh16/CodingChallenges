using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Arrays._1436.DestinationCity
{
    public class CodeFile
    {
        public string DestCity(IList<IList<string>> paths)
        {
            var result = string.Empty;
            var map = new Dictionary<string, string>();
            foreach (var path in paths)
            {
                map.Add(path[0], path[1]);
            }

            var start = map.First().Value;
            result = start;
            while (map.ContainsKey(start))
            {
                result = map[start];
                start = map[start];
            }

            return result;
        }
    }
}
