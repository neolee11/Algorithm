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
    public class _258_Add_Digits_Tests
    {
        [Theory]
        [InlineData(38, 2)]
        public void ShouldWork(int input, int expected)
        {
            var sut = new _258_Add_Digits();
            var output = sut.AddDigits(input);

            output.ShouldEqual(expected);
        }
    }
}
