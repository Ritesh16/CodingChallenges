using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Arrays.UniqueEmailAddresses
{
    class CodeFile_Fast
    {
        public int NumUniqueEmails(string[] emails)
        {
            var hashSet = new HashSet<string>();
            foreach (var mail in emails)
            {
                //Console.WriteLine("-- " + mail);
                StringBuilder str = new StringBuilder();
                var split = mail.Split("@");
                var user = split[0];
                var domain = split[1];
                for (int i = 0; i < user.Length; i++)
                {
                    if (user[i] == '.')
                    {
                        continue;
                    }
                    else if (user[i] == '+')
                    {
                        break;
                    }

                    str.Append(user[i]);
                }

                //Console.WriteLine("{0}@{1}", str.ToString(), domain);

                var finalMail = str.ToString() + "@" + domain;

                if (!hashSet.Contains(finalMail))
                {
                    //Console.WriteLine("added..");
                    hashSet.Add(finalMail);
                }
            }

            return hashSet.Count;
        }
    }
}
