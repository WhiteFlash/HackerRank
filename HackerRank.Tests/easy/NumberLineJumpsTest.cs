using FluentAssertions;
using HackerRank.programs.easy;
using Xunit;

namespace HackerRank.Tests.easy;

public class NumberLineJumpsTest
{
    [Theory]
    [InlineData(0, 3, 4, 2, "YES")]
    [InlineData(0, 2, 5, 3, "NO")]
    public void KangarooTest(int x1, int v1, int x2, int v2, string expected)
    {
        var actual = NumberLineJumps.Kangaroo(x1, v1, x2, v2);

        actual.Should().Be(expected);
    }
}