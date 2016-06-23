using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _338_Counting_Bits
    {
        public int[] CountBits(int num)
        {
            int[] solution = new int[num + 1];

            solution[0] = 0;

            for (int i = 1; i <= num; i++)
            {
                solution[i] = solution[i/2] + (i & 1);
            }

            return solution;
        }
    }
}
