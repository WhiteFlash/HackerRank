using FluentAssertions;
using HackerRank.programs.easy;
using Xunit;


namespace HackerRank.Tests.easy;

public class CountValleysTest
{
    [Theory]
    [InlineData(1, 8, "UDDDUDUU")]
    [InlineData(2, 10, "DUDDDUUDUU")]
    [InlineData(0, 10, "UDUUUDUDDD")]
    public void CountingValleysTest(int expected, int steps, string value)
    {
        var result = CountValleys.CountingValleys(steps, value);

        result.Should().Be(expected);
    }
}