using System;
using System.Collections.Generic;
using System.Text;

namespace Nunit_MSTest
{
    public class StringUtils
    {
        public string Reverse(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public bool IsPalindrome(string str)
        {
            return str == Reverse(str);
        }

        public string ToUpperCase(string str)
        {
            return str.ToUpper();
        }
    }
}
