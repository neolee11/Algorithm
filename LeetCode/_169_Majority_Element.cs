using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _169_Majority_Element
    {
        public int MajorityElement(int[] nums)
        {
            var majElement = nums[0];

            var count = 1;

            for(int i = 1; i < nums.Length; i++)
            {
                num = nums[i];
                if (num == majElement)
                    count++;
                else
                {
                    count--;
                    if (count == 0) majElement = num;
                }
            }

            return majElement;
        }
    }
}
