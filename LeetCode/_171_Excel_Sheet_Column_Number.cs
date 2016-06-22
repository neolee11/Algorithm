using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _171_Excel_Sheet_Column_Number
    {
        public int TitleToNumber(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            var power = 1;
            var val = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                val += (s[i] - 'A' + 1)*power;
                power *= 26;
            }

            return val;
        }
    }
}
