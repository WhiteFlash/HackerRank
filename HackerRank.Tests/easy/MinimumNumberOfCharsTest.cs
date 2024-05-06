using FluentAssertions;
using HackerRank.programs.easy;
using Xunit;

namespace HackerRank.Tests.easy;

public class MinimumNumberOfCharsTest
{
    [Theory]
    [InlineData(3, "Ab1", 3)]
    [InlineData(11, "#HackerRank", 1)]
    public void MinimumNumberTest(int n, string password, int expected)
    {
        var actual = MinimumNumberOfChars.MinimumNumber(n, password);

        actual.Should().Be(expected);
    }
}