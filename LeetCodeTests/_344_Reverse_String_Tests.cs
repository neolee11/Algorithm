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
    public class _344_Reverse_String_Tests
    {
        [Theory]
        [InlineData("abc", "cba")]
        [InlineData("hello", "olleh")]
        public void ShouldWork(string input, string expected)
        {
            var sut = new _344_Reverse_String();
            var output = sut.ReverseString(input);

            output.ShouldEqual(expected);
        }
    }
}
