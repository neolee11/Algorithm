using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*
        Given a non-negative integer num, repeatedly add all its digits until the result has only one digit.

        For example:

        Given num = 38, the process is like: 3 + 8 = 11, 1 + 1 = 2. Since 2 has only one digit, return it.

        Follow up:
        Could you do it without any loop/recursion in O(1) runtime?
    */
    public class _258_Add_Digits
    {
        public int AddDigits(int num)
        {
            while (num / 10 != 0)
            {
                var curr = 0;
                var reminder = num;
                while (reminder > 0)
                {
                    curr += reminder % 10;
                    reminder = reminder / 10;
                }

                num = curr;
            }

            return num;
        }
    }
}
