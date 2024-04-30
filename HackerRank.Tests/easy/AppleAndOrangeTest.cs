using HackerRank.programs.easy;
using Xunit;

namespace HackerRank.Tests.easy;

public class AppleAndOrangeTest
{
    [Fact]
    public void CountApplesAndOrangesTest()
    {
        var expected = (1,1);
        var result = AppleAndOrange.CountApplesAndOranges(7, 11, 5, 15, [-2, 2, 1], [5, -6]);

        Assert.Equal(expected, result);
    }
}