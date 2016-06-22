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
    public class _242_Valid_Anagram_Tests
    {
        [Theory]
        [InlineData("a", "a", true)]
        public void ShouldWork(string inputS, string inputT, bool expected)
        {
            var sut = new _242_Valid_Anagram();
            var output = sut.IsAnagram(inputS, inputT);

            output.ShouldEqual(expected);
        }
    }
}
