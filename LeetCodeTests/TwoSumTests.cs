using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using Xunit;

namespace LeetCodeTests
{
    public class TwoSumTests
    {
        [Theory]
        [InlineData(new int[] {3, 2, 4}, 6, new int[] { 1, 2 })]
        public void TestGetSolution(int[] nums, int target, int[] expectedResult)
        {
            var sut = new TwoSum();
            var mySolution = sut.GetSolution(nums, target);
            Assert.Equal(mySolution, expectedResult);
        }
    }
}
