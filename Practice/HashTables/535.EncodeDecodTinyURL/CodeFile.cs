using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.HashTables._535.EncodeDecodTinyURL
{
    public class CodeFile
    {
        Dictionary<string, string> urltoKey = new Dictionary<string, string>();
        Dictionary<string, string> keytoUrl = new Dictionary<string, string>();
        const string KeyCharacterSet = @"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        const string urlPrefix = "http://tinyurl.com/";

        public string encode(string longUrl)
        {
            var key = string.Empty;
            var random = new Random();
            if (!urltoKey.TryGetValue(longUrl, out key))
            {
                while (true)
                {
                    var builder = new StringBuilder();
                    for (int i = 0; i < 6; i++)
                    {
                        int index = random.Next(0, KeyCharacterSet.Length);
                        builder.Append(KeyCharacterSet[index]);
                    }

                    key = builder.ToString();
                    if (!keytoUrl.ContainsKey(key))
                    {
                        keytoUrl.Add(key, longUrl);
                        urltoKey.Add(longUrl, key);
                        break;
                    }
                }
            }

            return urlPrefix + key;

        }

        public string decode(string shortUrl)
        {
            string key = shortUrl.Replace(urlPrefix, string.Empty);
            return keytoUrl[key];
        }
    }
}
