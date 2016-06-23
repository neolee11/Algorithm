using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _136_Single_Number
    {
        public int SingleNumber(int[] nums)
        {
            int result = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                result = result ^ nums[i];
            }

            return result;

        }
    }
}
