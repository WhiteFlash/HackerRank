using System.Collections.Generic;
using HackerRank.programs.easy;
using Xunit;

namespace HackerRank.Tests.easy;

public class BreakingTheRecordsTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void BreakingRecordsTest(int[] scores, int[] expected)
    {
        var actual = BreakingTheRecords.BreakingRecords([.. scores]);

        Assert.Equal([.. expected], actual);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] { new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 }, new int[] { 2, 4 } };
        yield return new object[] { new int[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 }, new int[] { 4, 0 } };
    }
}