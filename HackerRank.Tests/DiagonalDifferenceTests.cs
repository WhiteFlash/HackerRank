using HackerRank.programs.easy;
using System.Collections.Generic;
using Xunit;

namespace HackerRank.Tests;

public class DiagonalDifferenceTests
{
    [Trait("Easy", "Diagonal")]
    [Fact]
    public void Diagonal_Test()
    {
        var matrix = new List<List<int>>()
        {
            new() { 3 },
            new() { 11, 2, 4 },
            new() { 4, 5, 6 },
            new() { 10, 8, -12 }
        };

        var result = DiagonalDifference.CountDiagonalDifference(matrix);

        Assert.Equal(15, result);
    }
}
