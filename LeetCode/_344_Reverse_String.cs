using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*
        Write a function that takes a string as input and returns the string reversed.

        Example:
        Given s = "hello", return "olleh".
    */
    public class _344_Reverse_String
    {
        public string ReverseString(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            var builder = new StringBuilder(s);

            for (int i = 0; i < builder.Length/2; i++)
            {
                var tmp = builder[i];
                builder[i] = builder[builder.Length - 1 - i];
                builder[builder.Length - 1 - i] = tmp;
            }

            return builder.ToString();
        }
    }
}
