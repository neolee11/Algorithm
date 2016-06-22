using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _283_Move_Zeroes
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums == null || nums.Length == 0) return;

            var nextZeroPosition = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nextZeroPosition] = nums[i];
                    nextZeroPosition++;
                }
            }

            while (nextZeroPosition < nums.Length)
            {
                nums[nextZeroPosition++] = 0;
            }
        }
    }
}
