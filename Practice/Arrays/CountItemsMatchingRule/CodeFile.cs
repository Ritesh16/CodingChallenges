using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.CountItemsMatchingRule
{
    public class CodeFile
    {
        //public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        //{
        //    var result = 0;
        //    for (int i = 0; i < items.Count; i++)
        //    {   
        //        if(ruleKey.ToLower() == "type")
        //        {
        //            result = GetResult(items[i], result, 0, ruleValue);
        //        }

        //        if (ruleKey.ToLower() == "color")
        //        {
        //            result = GetResult(items[i], result, 1, ruleValue);
        //        }

        //        if (ruleKey.ToLower() == "name")
        //        {
        //            result = GetResult(items[i], result, 2, ruleValue);
        //        }
        //    }

        //    return result;
        //}

        private int GetResult(IList<string> lists, int result, int v, string ruleValue)
        {
            if (lists[v] == ruleValue)
            {
                result++;
            }

            return result;
        }


        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            var result = 0;

            foreach (var item in items)
            {
                result += ruleKey switch
                {
                    "type" => item[0] == ruleValue ? 1 : 0,
                    "color" => item[1] == ruleValue ? 1: 0,
                    "name" => item[2] == ruleValue ? 1: 0,
                    _ => 0
                };
            }

            return result;
        }

    }
}
