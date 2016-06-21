using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using Should;
using Xunit;

namespace LeetCodeTests
{
    public class _1_Two_Sum_Tests
    {
        [Theory]
        [InlineData(5, 5)]
        public void SolutionShouldWork(int input, int output)
        {
            var sut = new _1_Two_Sum();

            output.ShouldEqual(input);
        }
    }
}
