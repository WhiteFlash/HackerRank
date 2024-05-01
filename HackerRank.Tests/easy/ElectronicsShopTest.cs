using System.Collections.Generic;
using FluentAssertions;
using HackerRank.programs.easy;
using Xunit;

namespace HackerRank.Tests.easy;

public class ElectronicsShopTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GetMoneySpentTest(int[] keyboards, int[] drives, int b, int expected)
    {
        var result = ElectronicsShop.GetMoneySpent(keyboards, drives, b);

        result.Should().Be(expected);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] { new int[] { 3, 1 }, new int[] { 5, 2, 8 }, 10, 9 };
        yield return new object[] { new int[] { 4 }, new int[] { 5 }, 5, -1 };
    }
}