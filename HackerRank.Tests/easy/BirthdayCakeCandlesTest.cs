using HackerRank.programs.easy;
using System.Collections.Generic;
using Xunit;

namespace HackerRank.Tests.easy;
public class BirthdayCakeCandlesTest
{
    [Trait("Easy", "CakeCandles")]
    [Fact]
    public void BirthdayCakeCandles_Test()
    {
        var array = new List<int> { 3, 2, 1, 3 };
        var result = BirthdayCakeCandles.RunProgram(array);

        Assert.Equal(2, result);
    }
}
