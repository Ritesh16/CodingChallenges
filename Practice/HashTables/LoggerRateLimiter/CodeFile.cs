using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.HashTables.LoggerRateLimiter
{
    public class Logger
    {
        Dictionary<string, int> dictionary;
        public Logger()
        {
            dictionary = new Dictionary<string, int>();
        }

        public bool ShouldPrintMessage(int timestamp, string message)
        {
            bool result = true;
            if (!dictionary.ContainsKey(message))
            {
                dictionary.Add(message, timestamp + 10);
            }
            else
            {
                var time = dictionary[message];
                if (time > timestamp)
                {
                    result = false;
                }
                else
                {
                    dictionary[message] = timestamp + 10;
                }
            }

            return result;
        }
    }
}
