using FluentAssertions;
using HackerRank.LeetCode.Easy;
using Xunit;

namespace HackerRank.Tests.LeetCodeTest.Easy;
public class TwoSumsTest
{
    [Fact]
    public void TwoSumsRunTest()
    {
        var result = TwoSums.CountTwoSum([2, 7, 11, 15], 9);

        result.Should().Equal([0, 1]);
    }
}

