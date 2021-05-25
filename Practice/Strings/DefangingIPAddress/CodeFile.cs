using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Strings.DefangingIPAddress
{
    public class CodeFile
    {
        public string DefangIPaddr(string address)
        {
            if (!string.IsNullOrEmpty(address))
            {
                return address.Replace(".", "[.]");
            }

            return address;
        }
    }
}
