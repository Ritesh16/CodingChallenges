using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.UniqueEmailAddresses
{
    class CodeFile
    {
        public int NumUniqueEmails(string[] emails)
        {
            if (emails == null || emails.Length == 0)
            {
                return 0;
            }

            var hashSet = new HashSet<string>();
            foreach (var email in emails)
            {
                var address = email.Split('@');
                var domain = address[1];

                var name = address[0];
                var userName = name.Split('+');

                var userNameWithDot = userName[0].Split('.');
                var refinedName = string.Join("", userNameWithDot);
                hashSet.Add(refinedName + "@" + domain);
            }

            return hashSet.Count;
        }
    }
}
