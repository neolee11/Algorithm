using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TwoSum
    {
        /*
            1. Two Sum

            Given an array of integers, find two numbers such that they add up to a specific target number.
            The function twoSum should return indices of the two numbers such that they add up to the target, 
            where index1 must be less than index2. Please note that your returned answers (both index1 and index2) 
            are not zero-based.
            You may assume that each input would have exactly one solution.

            Input: numbers={2, 7, 11, 15}, target=9
            Output: index1=1, index2=2
        */

        public int[] GetSolution(int[] nums, int target)
        {
            int[] results = new int[2];

            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }

            int[] hash = new int[max+1];

            for (int i = 0; i < nums.Length; i++)
            {
                hash[nums[i]] = i + 1;
            }

            var index1 = -1;
            var index2 = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                index1 = i;
                int remainder = target - nums[i];
                if (hash[remainder] > 0 && (hash[remainder] - 1) != i)
                {
                    index2 = hash[remainder] - 1;
                    break;
                }
            }

            if (index2 < index1)
            {
                var temp = index2;
                index2 = index1;
                index1 = temp;
            }

            if (index1 >= 0 && index2 > 0)
            {
                results[0] = index1;
                results[1] = index2;
            }

            return results;
        }
    }
}
