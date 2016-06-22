using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _349_Intersection_of_Two_Arrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set = new HashSet<int>();
            HashSet<int> intersect = new HashSet<int>();

            int i = 0;
            for (i = 0; i < nums1.Length; i++)
            {
                set.Add(nums1[i]);
            }

            for (i = 0; i < nums2.Length; i++)
            {
                if (set.Contains(nums2[i]))
                {
                    intersect.Add(nums2[i]);
                }
            }
            int[] result = new int[intersect.Count];
            i = 0;
            foreach (int num in intersect)
            {
                result[i++] = num;
            }
            return result;
        }
    }
}
